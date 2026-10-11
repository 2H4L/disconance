using System.Net;
using Disconance.Http.Requests;
using Disconance.Http.Requests.Interactions;
using Disconance.Http.Requests.Messages;
using Disconance.Http.Responses;
using Disconance.Models.Interactions;

namespace Disconance.Http.Tests;

public class TestDiscordHttpClient
{
    [Fact]
    public async Task SendAsync_OptionsChangedAfterConstruction_UsesOriginalCredential()
    {
        string? authorization = null;
        var options = new DiscordHttpOptions { Token = "original" };

        var handler = new CallbackHandler(request =>
        {
            authorization = request.Headers.Authorization?.ToString();
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NoContent));
        });

        using var sut = new DiscordHttpClient(options, handler);
        options.Token = "changed";

        await sut.SendAsync(Request());

        Assert.Equal("Bot original", authorization);
    }

    [Fact]
    public async Task SendAsync_LearnedSharedBucket_UsesCooldownAcrossMethodsAndRoutes()
    {
        var time = new ManualTimeProvider();
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            var response = new HttpResponseMessage(HttpStatusCode.NoContent);
            response.Headers.Add("X-RateLimit-Bucket", "shared");
            response.Headers.Add("X-RateLimit-Remaining", ++calls == 2 ? "0" : "1");
            response.Headers.Add("X-RateLimit-Reset-After", "0.75");
            return Task.FromResult(response);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler, time);
        await sut.SendAsync(Request());
        await sut.SendAsync(Request(endpoint: "pins"));

        var pending = sut.SendAsync(Request());
        await time.DelayScheduled.WaitAsync(TimeSpan.FromSeconds(5));
        await sut.SendAsync(Request("43"));
        Assert.Equal(3, calls);
        time.Advance(TimeSpan.FromSeconds(0.75));
        await pending.WaitAsync(TimeSpan.FromSeconds(5));

        Assert.Equal(4, calls);
    }

    [Fact]
    public async Task SendAsync_GlobalCooldown_BlocksOtherBotRoutesButNotInteractionCallbacks()
    {
        var time = new ManualTimeProvider();
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            var response =
                new HttpResponseMessage(++calls == 1 ? HttpStatusCode.TooManyRequests : HttpStatusCode.NoContent);

            if (calls == 1)
            {
                response.Content = new StringContent("{\"retry_after\":1,\"global\":true}");
            }

            return Task.FromResult(response);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret", MaxRateLimitRetries = 0 },
            handler, time);

        await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(Request()));

        var blocked = sut.SendAsync(Request("43"));
        await time.DelayScheduled.WaitAsync(TimeSpan.FromSeconds(5));

        await sut.SendAsync(new DiscordRequest<NoContent>(HttpMethod.Post,
                new DiscordRoute("interactions/{interaction.id}/{interaction.token}/callback",
                    new Dictionary<string, string> { ["interaction.id"] = "7", ["interaction.token"] = "token" }))
            { UseAuthorization = false });

        Assert.Equal(2, calls);
        time.Advance(TimeSpan.FromSeconds(1));
        await blocked.WaitAsync(TimeSpan.FromSeconds(5));

        Assert.Equal(3, calls);
    }

    [Fact]
    public async Task SendAsync_Retry_SnapshotsPayloadBeforeWaiting()
    {
        var time = new ManualTimeProvider();
        var payload = new CreateMessageBody { Content = "original" };
        var bodies = new List<string>();

        using var handler = new CallbackHandler(async request =>
        {
            bodies.Add(await request.Content!.ReadAsStringAsync());

            if (bodies.Count == 1)
            {
                payload.Content = "changed";

                return new HttpResponseMessage(HttpStatusCode.TooManyRequests)
                    { Content = new StringContent("{\"retry_after\":1}") };
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler, time);

        var operation = sut.SendAsync(new CreateMessageRequest(42, payload));
        await time.DelayScheduled.WaitAsync(TimeSpan.FromSeconds(5));
        time.Advance(TimeSpan.FromSeconds(1));
        await operation.WaitAsync(TimeSpan.FromSeconds(5));

        Assert.Equal(new[] { "{\"content\":\"original\"}", "{\"content\":\"original\"}" }, bodies);
    }

    [Fact]
    public void Dispose_OwnedTransport_DisposesHandler()
    {
        var handler = new CallbackHandler(_ =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.NoContent)));

        var sut = new DiscordHttpClient(new DiscordHttpOptions(), handler);

        sut.Dispose();

        Assert.True(handler.IsDisposed);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task SendAsync_Callback_ReturnsOptionalResourceWithoutAuthorization(bool withResponse)
    {
        var authorization = "unset";
        string? query = null;

        using var handler = new CallbackHandler(request =>
        {
            authorization = request.Headers.Authorization?.ToString();
            query = request.RequestUri!.Query;

            return Task.FromResult(new HttpResponseMessage(withResponse ? HttpStatusCode.OK : HttpStatusCode.NoContent)
            {
                Content = new StringContent(withResponse ? "{\"interaction\":{\"id\":\"42\",\"type\":2}}" : "")
            });
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);

        var request = new CreateInteractionResponseRequest(42, "token",
                new InteractionResponse { Type = InteractionCallbackType.Pong })
            { WithResponse = withResponse };

        var response = await sut.SendAsync(request);

        Assert.Null(authorization);
        Assert.Equal(withResponse, response.HasBody);
        Assert.Equal(withResponse, response.Data is not null);
        Assert.Equal("?with_response=" + withResponse.ToString().ToLowerInvariant(), query);
    }

    [Fact]
    public async Task SendAsync_UnauthorizedCredential_StopsLaterAuthenticatedRequests()
    {
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            calls++;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.Unauthorized));
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);
        await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(Request()));

        await Assert.ThrowsAsync<InvalidOperationException>(() => sut.SendAsync(Request("43")));

        Assert.Equal(1, calls);
    }

    private static DiscordRequest<NoContent> Request(string channel = "42", string endpoint = "messages")
    {
        return new DiscordRequest<NoContent>(HttpMethod.Get, new DiscordRoute("channels/{channel.id}/" + endpoint,
            new Dictionary<string, string> { ["channel.id"] = channel }));
    }

    [Fact]
    public async Task SendAsync_UnrelatedBucket_DoesNotWaitForSlowRequest()
    {
        var started = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        var release = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);

        using var handler = new CallbackHandler(async request =>
        {
            if (request.RequestUri!.AbsolutePath.Contains("/42/"))
            {
                started.SetResult();
                await release.Task;
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);
        var slow = sut.SendAsync(Request());
        await started.Task;

        var fast = await sut.SendAsync(Request("43")).WaitAsync(TimeSpan.FromSeconds(5));

        Assert.False(slow.IsCompleted);
        Assert.Equal(HttpStatusCode.NoContent, fast.StatusCode);
        release.SetResult();
        await slow;
    }

    [Theory]
    [InlineData("user")]
    [InlineData("shared")]
    [InlineData("global")]
    public async Task SendAsync_RateLimited_WaitsFractionalDelayAndRetries(string scope)
    {
        var time = new ManualTimeProvider();
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            var response =
                new HttpResponseMessage(++calls == 1 ? HttpStatusCode.TooManyRequests : HttpStatusCode.NoContent);

            if (calls == 1)
            {
                response.Headers.Add("X-RateLimit-Scope", scope);
                response.Headers.Add("X-RateLimit-Remaining", "9");
                response.Content = new StringContent("{\"retry_after\":0.5}");
            }

            return Task.FromResult(response);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler, time);

        var operation = sut.SendAsync(Request());
        await time.DelayScheduled.WaitAsync(TimeSpan.FromSeconds(5));
        Assert.Equal(1, calls);
        time.Advance(TimeSpan.FromSeconds(0.5));
        await operation.WaitAsync(TimeSpan.FromSeconds(5));

        Assert.Equal(2, calls);
    }

    [Fact]
    public async Task SendAsync_CancelledCooldown_DoesNotRetry()
    {
        var time = new ManualTimeProvider();
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            calls++;

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.TooManyRequests)
                { Content = new StringContent("{\"retry_after\":2}") });
        });

        using var cancellation = new CancellationTokenSource();
        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler, time);
        var operation = sut.SendAsync(Request(), cancellation.Token);
        await time.DelayScheduled.WaitAsync(TimeSpan.FromSeconds(5));

        cancellation.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => operation);
        Assert.Equal(1, calls);
    }

    [Theory]
    [InlineData(404, 10008, 2)]
    [InlineData(404, 10015, 1)]
    [InlineData(401, 0, 2)]
    public async Task SendAsync_WebhookError_OnlyUnknownWebhookDisablesIdentity(int status, int code, int expectedCalls)
    {
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            calls++;

            return Task.FromResult(new HttpResponseMessage((HttpStatusCode)status)
                { Content = new StringContent($"{{\"code\":{code}}}") });
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions(), handler);

        var request = new DiscordRequest<NoContent>(HttpMethod.Get,
                new DiscordRoute("webhooks/{webhook.id}/{webhook.token}/messages/@original",
                    new Dictionary<string, string> { ["webhook.id"] = "42", ["webhook.token"] = "secret" }, true))
            { UseAuthorization = false };

        await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(request));

        var second = await Record.ExceptionAsync(() => sut.SendAsync(request));

        Assert.NotNull(second);
        Assert.Equal(expectedCalls, calls);
    }

    [Fact]
    public async Task SendAsync_ExhaustedRetries_ThrowsFinalApiError()
    {
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            calls++;

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.TooManyRequests)
                { Content = new StringContent("{\"retry_after\":1}") });
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret", MaxRateLimitRetries = 0 },
            handler);

        await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(Request()));

        Assert.Equal(1, calls);
    }

    [Theory]
    [InlineData(500)]
    [InlineData(502)]
    public async Task SendAsync_ServerFailure_DoesNotRetryWrite(int status)
    {
        var calls = 0;

        using var handler = new CallbackHandler(_ =>
        {
            calls++;
            return Task.FromResult(new HttpResponseMessage((HttpStatusCode)status));
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);

        await Assert.ThrowsAsync<DiscordHttpException>(() =>
            sut.SendAsync(new DiscordRequest<NoContent>(HttpMethod.Post, new DiscordRoute("users/@me"))));

        Assert.Equal(1, calls);
    }

    [Fact]
    public async Task SendAsync_MalformedRateLimitJson_FallsBackWithoutMaskingApiError()
    {
        using var handler = new CallbackHandler(_ => Task.FromResult(
            new HttpResponseMessage(HttpStatusCode.TooManyRequests)
                { Content = new StringContent("{\"retry_after\":\"oops\"}") }));

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret", MaxRateLimitRetries = 0 },
            handler);

        await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(Request()));
    }

    [Fact]
    public async Task SendAsync_ExplicitPayload_SeparatesMetadata()
    {
        string? body = null;
        string? authorization = null;
        Uri? uri = null;

        using var handler = new CallbackHandler(async request =>
        {
            body = await request.Content!.ReadAsStringAsync();
            authorization = request.Headers.Authorization?.ToString();
            uri = request.RequestUri;
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        });

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);

        var request = new DiscordRequest<NoContent>(HttpMethod.Post,
                new DiscordRoute("channels/{channel.id}/messages",
                    new Dictionary<string, string> { ["channel.id"] = "42" }))
            { Body = new { content = "Hello", tts = false } };

        var result = await sut.SendAsync(request);

        Assert.Equal("{\"content\":\"Hello\",\"tts\":false}", body);
        Assert.Equal("Bot secret", authorization);
        Assert.Equal("https://discord.com/api/v10/channels/42/messages", uri!.AbsoluteUri);
        Assert.False(result.HasBody);
    }

    [Fact]
    public async Task SendAsync_ApiFailure_ExposesStructuredError()
    {
        using var handler = new CallbackHandler(_ => Task.FromResult(new HttpResponseMessage(HttpStatusCode.BadRequest)
        {
            Content = new StringContent(
                "{\"code\":50035,\"message\":\"Invalid form body\",\"errors\":{\"content\":{}}}")
        }));

        using var sut = new DiscordHttpClient(new DiscordHttpOptions { Token = "secret" }, handler);

        var error = await Assert.ThrowsAsync<DiscordHttpException>(() => sut.SendAsync(
            new DiscordRequest<NoContent>(HttpMethod.Get, new DiscordRoute("users/@me"))));

        Assert.Equal(50035, error.Code);
        Assert.NotNull(error.Errors);
        Assert.DoesNotContain("secret", error.Message);
    }
}

internal sealed class CallbackHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> callback) : HttpMessageHandler
{
    public bool IsDisposed { get; private set; }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            IsDisposed = true;
        }

        base.Dispose(disposing);
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        return callback(request);
    }
}