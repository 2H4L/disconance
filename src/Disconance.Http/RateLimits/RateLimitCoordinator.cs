using System.Globalization;
using System.Net;
using System.Text.Json;
using Disconance.Http.Requests;

namespace Disconance.Http.RateLimits;

internal sealed class RateLimitCoordinator(DiscordHttpOptions options, TimeProvider time)
{
    private readonly Dictionary<string, Bucket> _buckets = [];
    private readonly HashSet<string> _deadWebhooks = [];
    private readonly Dictionary<string, Queue<DateTimeOffset>> _globalRequests = [];
    private readonly Dictionary<string, DateTimeOffset> _globalUntil = [];
    private readonly Queue<DateTimeOffset> _invalid = [];
    private readonly Dictionary<string, Bucket> _routes = [];
    private readonly long _start = time.GetTimestamp();
    private readonly Lock _sync = new();
    private bool _invalidCredential;

    private DateTimeOffset Now
    {
        get => field + time.GetElapsedTime(_start);
    } = time.GetUtcNow();

    internal async Task<Lease> AcquireAsync<T>(IDiscordRequest<T> request, CancellationToken cancellationToken)
    {
        var route = request.Route;
        var domain = route.IsInteraction ? "interaction" : request.UseAuthorization ? "authenticated" : "anonymous";
        var key = $"{domain}:{request.Method}:{route.Template}:{route.MajorKey}";

        while (true)
        {
            Bucket? bucket;

            lock (_sync)
            {
                if (!_routes.TryGetValue(key, out bucket))
                {
                    _routes[key] = bucket = new Bucket();
                }
            }

            await bucket.Gate.WaitAsync(cancellationToken).ConfigureAwait(false);
            TimeSpan delay;

            try
            {
                lock (_sync)
                {
                    if (!ReferenceEquals(bucket, _routes[key]))
                    {
                        continue;
                    }

                    var now = Now;

                    while (_invalid.TryPeek(out var invalid) && invalid <= now.AddMinutes(-10))
                    {
                        _invalid.Dequeue();
                    }

                    if (request.UseAuthorization && _invalidCredential)
                    {
                        throw new InvalidOperationException(
                            "Discord rejected this credential; create a client with a valid token.");
                    }

                    if (route.WebhookKey is { } webhook && _deadWebhooks.Contains(webhook))
                    {
                        throw new InvalidOperationException("Discord reported an unknown webhook.");
                    }

                    if (_invalid.Count >= options.InvalidRequestThreshold)
                    {
                        throw new InvalidOperationException(
                            "Local invalid-request threshold reached; wait for the rolling window to expire.");
                    }

                    var until = bucket.Until > _globalUntil.GetValueOrDefault(domain)
                        ? bucket.Until
                        : _globalUntil.GetValueOrDefault(domain);

                    if (!_globalRequests.TryGetValue(domain, out var queue))
                    {
                        _globalRequests[domain] = queue = new Queue<DateTimeOffset>();
                    }

                    while (queue.TryPeek(out var stamp) && stamp <= now.AddSeconds(-1))
                    {
                        queue.Dequeue();
                    }

                    if (!route.IsInteraction && queue.Count >= options.GlobalRequestsPerSecond &&
                        queue.Peek().AddSeconds(1) > until)
                    {
                        until = queue.Peek().AddSeconds(1);
                    }

                    delay = until - now;

                    if (delay <= TimeSpan.Zero)
                    {
                        if (!route.IsInteraction)
                        {
                            queue.Enqueue(now);
                        }

                        // Transfer gate ownership to the lease.
                        var held = bucket;
                        bucket = null;

                        return new Lease(() => held.Gate.Release(), (response, body) =>
                            Observe(request, key, domain, held, response, body));
                    }
                }
            }
            finally
            {
                bucket?.Gate.Release();
            }

            await Task.Delay(delay > TimeSpan.FromDays(1) ? TimeSpan.FromDays(1) : delay, time, cancellationToken)
                .ConfigureAwait(false);
        }
    }

    private void Observe<T>(IDiscordRequest<T> request, string key, string domain, Bucket held,
        HttpResponseMessage response, string body)
    {
        lock (_sync)
        {
            var now = Now;
            var scope = Header(response, "X-RateLimit-Scope");

            if (response.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden ||
                (response.StatusCode == HttpStatusCode.TooManyRequests && scope != "shared"))
            {
                _invalid.Enqueue(now);
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized && request.UseAuthorization)
            {
                _invalidCredential = true;
            }

            if (response.StatusCode == HttpStatusCode.NotFound && request.Route.WebhookKey is { } webhook &&
                ErrorCode(body) == 10015)
            {
                _deadWebhooks.Add(webhook);
            }

            var bucket = held;

            if (Header(response, "X-RateLimit-Bucket") is { } hash)
            {
                var bucketKey = $"{domain}:{hash}:{request.Route.MajorKey}";

                if (_buckets.TryGetValue(bucketKey, out var learned))
                {
                    bucket = learned;

                    if (held.Until > bucket.Until)
                    {
                        bucket.Until = held.Until;
                    }
                }
                else
                {
                    _buckets[bucketKey] = bucket;
                }

                _routes[key] = bucket;
            }

            if (Number(Header(response, "X-RateLimit-Remaining")) == 0)
            {
                var seconds = Number(Header(response, "X-RateLimit-Reset-After"));

                if (seconds is null && Number(Header(response, "X-RateLimit-Reset")) is { } epoch)
                {
                    seconds = Math.Max(0, epoch - (response.Headers.Date ?? now).ToUnixTimeMilliseconds() / 1000d);
                }

                Extend(bucket, Deadline(now, seconds ?? 1));
            }

            if (response.StatusCode != HttpStatusCode.TooManyRequests)
            {
                return;
            }

            var retry = Number(Header(response, "Retry-After"));

            if (retry is null && response.Headers.RetryAfter?.Date is { } date)
            {
                retry = Math.Max(0, (date - (response.Headers.Date ?? now)).TotalSeconds);
            }

            var global = scope == "global" || Header(response, "X-RateLimit-Global") == "true";

            try
            {
                using var json = JsonDocument.Parse(body);
                var root = json.RootElement;

                if (root.ValueKind == JsonValueKind.Object)
                {
                    if (root.TryGetProperty("retry_after", out var value) && value.ValueKind == JsonValueKind.Number &&
                        value.TryGetDouble(out var seconds) && double.IsFinite(seconds) && seconds >= 0)
                    {
                        retry = Math.Max(retry ?? 0, seconds);
                    }

                    if (root.TryGetProperty("global", out value) && value.ValueKind == JsonValueKind.True)
                    {
                        global = true;
                    }
                }
            }
            catch (JsonException)
            {
            }

            var until = Deadline(now, Math.Max(retry ?? 1, 0.01));

            if (global)
            {
                _globalUntil[domain] = until > _globalUntil.GetValueOrDefault(domain)
                    ? until
                    : _globalUntil.GetValueOrDefault(domain);
            }
            else
            {
                Extend(bucket, until);
                Extend(held, until);
            }
        }
    }

    private static void Extend(Bucket bucket, DateTimeOffset until)
    {
        if (until > bucket.Until)
        {
            bucket.Until = until;
        }
    }

    private static DateTimeOffset Deadline(DateTimeOffset now, double seconds)
    {
        return now.AddSeconds(Math.Min(seconds, (DateTimeOffset.MaxValue - now).TotalSeconds - 1));
    }

    private static long? ErrorCode(string body)
    {
        try
        {
            using var document = JsonDocument.Parse(body);

            return document.RootElement.ValueKind == JsonValueKind.Object &&
                   document.RootElement.TryGetProperty("code", out var code) &&
                   code.ValueKind == JsonValueKind.Number && code.TryGetInt64(out var value)
                ? value
                : null;
        }
        catch (JsonException)
        {
            return null;
        }
    }

    private static string? Header(HttpResponseMessage response, string name)
    {
        return response.Headers.TryGetValues(name, out var values) ? values.FirstOrDefault() : null;
    }

    private static double? Number(string? text)
    {
        return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var number) &&
               double.IsFinite(number) && number >= 0
            ? number
            : null;
    }

    private sealed class Bucket
    {
        internal readonly SemaphoreSlim Gate = new(1, 1);
        internal DateTimeOffset Until;
    }

    internal sealed class Lease(Action release, Action<HttpResponseMessage, string> observe) : IDisposable
    {
        public void Dispose()
        {
            release();
        }

        internal void Observe(HttpResponseMessage response, string body)
        {
            observe(response, body);
        }
    }
}