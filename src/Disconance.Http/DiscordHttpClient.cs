using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using Disconance.Http.RateLimits;
using Disconance.Http.Requests;
using Disconance.Http.Responses;

namespace Disconance.Http;

/// <summary>
///     A thread-safe, long-lived Discord transport. Rate-limit state is local to this instance.
/// </summary>
public sealed class DiscordHttpClient : IDiscordRequestSender, IDisposable
{
    private static readonly Uri BaseUri = new("https://discord.com/api/v10/");

    private static readonly string UserAgent = "DiscordBot (https://github.com/2H4L/disconance, " +
                                               (typeof(DiscordHttpClient).Assembly
                                                   .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                                   ?.InformationalVersion ?? "0.0.0") + ")";

    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _json;
    private readonly DiscordHttpOptions _options;
    private readonly RateLimitCoordinator _rates;
    private readonly TimeProvider _time;

    /// <summary>
    ///     Creates a client that owns and configures its HTTP transport.
    /// </summary>
    public DiscordHttpClient(DiscordHttpOptions options)
        : this(options, null)
    {
    }

    // Internal transport and clock substitution keeps tests deterministic and offline.
    internal DiscordHttpClient(DiscordHttpOptions options, HttpMessageHandler? handler,
        TimeProvider? timeProvider = null)
    {
        ArgumentNullException.ThrowIfNull(options);

        if (options.AuthenticationScheme is not ("Bot" or "Bearer") ||
            (options.Token is not null &&
             (string.IsNullOrWhiteSpace(options.Token) || options.Token.Any(char.IsWhiteSpace))))
        {
            throw new ArgumentException("Supply a Bot or Bearer token without whitespace.", nameof(options));
        }

        if (options.MaxRateLimitRetries < 0 || options.GlobalRequestsPerSecond < 1 ||
            options.InvalidRequestThreshold is < 1 or >= 10000 || options.RequestTimeout <= TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(options));
        }

        _json = new JsonSerializerOptions(options.SerializerOptions);

        _options = new DiscordHttpOptions
        {
            Token = options.Token,
            AuthenticationScheme = options.AuthenticationScheme,
            RequestTimeout = options.RequestTimeout,
            MaxRateLimitRetries = options.MaxRateLimitRetries,
            GlobalRequestsPerSecond = options.GlobalRequestsPerSecond,
            InvalidRequestThreshold = options.InvalidRequestThreshold,
            SerializerOptions = _json
        };

        _time = timeProvider ?? TimeProvider.System;
        _rates = new RateLimitCoordinator(_options, _time);

        _http = new HttpClient(handler ?? new SocketsHttpHandler
        {
            AllowAutoRedirect = false, PooledConnectionLifetime = TimeSpan.FromMinutes(5)
        })
        {
            Timeout = Timeout.InfiniteTimeSpan
        };
    }

    /// <inheritdoc />
    public async Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        ArgumentNullException.ThrowIfNull(request.Method);
        ArgumentNullException.ThrowIfNull(request.Route);

        if (request.Body is not null && request.ContentFactory is not null)
        {
            throw new ArgumentException("Body and ContentFactory are mutually exclusive.", nameof(request));
        }

        if (request.UseAuthorization && _options.Token is null)
        {
            throw new InvalidOperationException("This endpoint requires a configured credential.");
        }

        if (request.AuditLogReason?.EnumerateRunes().Count() is < 1 or > 512)
        {
            throw new ArgumentException("Audit reasons must contain 1 to 512 characters.", nameof(request));
        }

        // Snapshot all transport metadata and JSON once. Every retry represents the same operation.
        var snapshot = new DiscordRequest<T>(request.Method, request.Route)
        {
            UseAuthorization = request.UseAuthorization,
            AuditLogReason = request.AuditLogReason,
            Query = request.Query is null ? null : new Dictionary<string, string?>(request.Query),
            ContentFactory = request.ContentFactory
        };

        var json = request.Body is { } body ? JsonSerializer.Serialize(body, body.GetType(), _json) : null;

        var query = snapshot.Query is null
            ? ""
            : string.Join("&", snapshot.Query.Where(p => p.Value is not null)
                .Select(p => Uri.EscapeDataString(p.Key) + "=" + Uri.EscapeDataString(p.Value!)));

        var uri = new Uri(BaseUri, snapshot.Route.Path + (query.Length == 0 ? "" : "?" + query));

        for (var attempt = 0;; attempt++)
        {
            using var lease = await _rates.AcquireAsync(snapshot, cancellationToken).ConfigureAwait(false);
            using var timeout = new CancellationTokenSource(_options.RequestTimeout, _time);
            using var linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeout.Token);
            using var message = new HttpRequestMessage(snapshot.Method, uri);
            message.Headers.UserAgent.ParseAdd(UserAgent);

            if (snapshot.UseAuthorization)
            {
                message.Headers.Authorization =
                    new AuthenticationHeaderValue(_options.AuthenticationScheme, _options.Token);
            }

            if (snapshot.AuditLogReason is { } reason)
            {
                message.Headers.Add("X-Audit-Log-Reason", Uri.EscapeDataString(reason));
            }

            message.Content = snapshot.ContentFactory?.Invoke();

            if (snapshot.ContentFactory is not null && message.Content is null)
            {
                throw new InvalidOperationException("ContentFactory must return fresh content.");
            }

            if (json is not null)
            {
                message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            using var response = await _http.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, linked.Token)
                .ConfigureAwait(false);

            var responseBody = await response.Content.ReadAsStringAsync(linked.Token).ConfigureAwait(false);
            lease.Observe(response, responseBody);

            if (response.StatusCode == HttpStatusCode.TooManyRequests &&
                attempt < _options.MaxRateLimitRetries)
            {
                continue;
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new DiscordHttpException(response.StatusCode, responseBody);
            }

            var hasBody = !string.IsNullOrWhiteSpace(responseBody);

            return new DiscordResponse<T>
            {
                StatusCode = response.StatusCode,
                HasBody = hasBody,
                Data = hasBody ? JsonSerializer.Deserialize<T>(responseBody, _json) : default,
                Headers = response.Headers.Concat(response.Content.Headers)
                    .GroupBy(p => p.Key, StringComparer.OrdinalIgnoreCase)
                    .ToDictionary(p => p.Key, p => p.SelectMany(v => v.Value).ToArray(),
                        StringComparer.OrdinalIgnoreCase)
            };
        }
    }

    /// <summary>
    ///     Disposes the HTTP transport owned by this client.
    /// </summary>
    public void Dispose()
    {
        _http.Dispose();
    }
}
