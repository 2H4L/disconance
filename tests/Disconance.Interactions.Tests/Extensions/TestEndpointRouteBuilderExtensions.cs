using System.Net;
using System.Text;
using System.Text.Json;
using Disconance.Interactions.Extensions;
using Disconance.Interactions.Middleware;
using Disconance.Interactions.Tests.Commands;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSec.Cryptography;

namespace Disconance.Interactions.Tests.Extensions;

public class TestEndpointRouteBuilderExtensions
{
    private const string CommandBody = """
                                       {"id":"1","application_id":"2","type":2,"token":"secret","version":1,
                                        "app_permissions":"0","entitlements":[],"authorizing_integration_owners":{},
                                        "attachment_size_limit":10485760,"data":{"id":"3","name":"ping","type":1}}
                                       """;

    [Fact]
    public async Task MapDisconanceInteractions_SignedMinimalPing_ReturnsJsonPongWithoutDispatch()
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign("""{"type":1}""");

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("application/json", response.Content.Headers.ContentType?.MediaType);
        Assert.Equal("""{"type":1}""", await response.Content.ReadAsStringAsync());
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Fact]
    public async Task MapDisconanceInteractions_SignedCommand_UsesDiscordJsonAndCustomHandler()
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        using var json = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal(4, json.RootElement.GetProperty("type").GetInt32());
        Assert.Equal("Pong!", json.RootElement.GetProperty("data").GetProperty("content").GetString());
        Assert.False(json.RootElement.GetProperty("data").TryGetProperty("embeds", out _));
        Assert.Equal(1, sut.Handler.Calls);
        Assert.IsType<ApplicationCommandData>(sut.Handler.Received!.Data.Value);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("not-hex")]
    [InlineData("ab")]
    public async Task MapDisconanceInteractions_MissingOrMalformedSignature_RejectsBeforeDispatch(string? signature)
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody);
        request.Headers.Remove("X-Signature-Ed25519");

        if (signature is not null)
        {
            request.Headers.TryAddWithoutValidation("X-Signature-Ed25519", signature);
        }

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Theory]
    [InlineData("X-Signature-Timestamp")]
    [InlineData("X-Signature-Ed25519")]
    public async Task MapDisconanceInteractions_DuplicateSecurityHeader_RejectsRequest(string header)
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody);
        request.Headers.TryAddWithoutValidation(header, request.Headers.GetValues(header).Single());

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task MapDisconanceInteractions_TamperedBodyOrTimestamp_RejectsRequest(bool changeBody)
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody);

        if (changeBody)
        {
            request.Content = new StringContent(CommandBody + " ");
        }
        else
        {
            request.Headers.Remove("X-Signature-Timestamp");
            request.Headers.Add("X-Signature-Timestamp", "1700000001");
        }

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Theory]
    [InlineData("{")]
    [InlineData("null")]
    [InlineData("[]")]
    [InlineData("{}")]
    [InlineData("""{"type":"1"}""")]
    [InlineData("""{"type":2}""")]
    [InlineData("""{"type":99,"data":{}}""")]
    public async Task MapDisconanceInteractions_SignedMalformedPayload_ReturnsBadRequest(string body)
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(body);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task MapDisconanceInteractions_BodyAboveLimit_RejectsKnownAndUnknownLengths(bool knownLength)
    {
        using var sut = new EndpointHost(maxBodySize: 16);
        using var request = sut.Sign(new string(' ', 17), knownLength);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.RequestEntityTooLarge, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Fact]
    public async Task MapDisconanceInteractions_UnknownLengthUtf8Body_VerifiesOriginalBytes()
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody.Replace("ping", "café🚚"), false);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("café🚚", Assert.IsType<ApplicationCommandData>(sut.Handler.Received!.Data.Value).Name);
    }

    [Fact]
    public async Task MapDisconanceInteractions_NoMatchingHandler_ReturnsNotFound()
    {
        using var sut = new EndpointHost();
        sut.Handler.Response = null;
        using var request = sut.Sign(CommandBody);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task MapDisconanceInteractions_OrderedMiddleware_WrapsDispatchInRegistrationOrder()
    {
        var events = new List<string>();

        using var sut = new EndpointHost(services =>
        {
            services.AddScoped<IInteractionMiddleware>(_ => new RecordingMiddleware("first", events));
            services.AddScoped<IInteractionMiddleware>(_ => new RecordingMiddleware("second", events));
        });

        using var request = sut.Sign(CommandBody);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal(["first:before", "second:before", "second:after", "first:after"], events);
        Assert.Equal(1, sut.Handler.Calls);
    }

    [Fact]
    public async Task MapDisconanceInteractions_ShortCircuitingMiddleware_DoesNotDispatch()
    {
        using var sut = new EndpointHost(services =>
            services.AddScoped<IInteractionMiddleware, ShortCircuitMiddleware>());

        using var request = sut.Sign(CommandBody);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    [Fact]
    public async Task MapDisconanceInteractions_ShortCircuitingMiddleware_DoesNotConstructCommandServices()
    {
        using var sut = new EndpointHost(services =>
        {
            services.AddScoped<IInteractionHandler>(_ => throw new InvalidOperationException("Must not resolve."));
            services.AddScoped<IInteractionMiddleware, ShortCircuitMiddleware>();
        });

        using var request = sut.Sign(CommandBody);

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task MapDisconanceInteractions_Ping_DoesNotResolveScopedApplicationServices()
    {
        using var sut = new EndpointHost(services =>
            services.AddScoped<IInteractionMiddleware>(_ =>
                throw new InvalidOperationException("Not needed for ping.")));

        using var request = sut.Sign("""{"type":1}""");

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task MapDisconanceInteractions_SignedGroupedCommand_UsesRegisteredHierarchyEndToEnd()
    {
        using var sut = new EndpointHost(
            services => services.AddInteraction<CommandTestData.Ban>(), customHandler: false);

        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("users", ApplicationCommandOptionType.SubCommandGroup,
                CommandTestData.Nested("ban", ApplicationCommandOptionType.SubCommand)));

        using var request =
            sut.Sign(JsonSerializer.Serialize(CommandTestData.Interaction(data: data), DiscordJson.CreateOptions()));

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        using var json = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
        Assert.Equal("banned", json.RootElement.GetProperty("data").GetProperty("content").GetString());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("-1")]
    [InlineData("a")]
    public async Task MapDisconanceInteractions_MissingOrMalformedTimestamp_RejectsBeforeDispatch(string? timestamp)
    {
        using var sut = new EndpointHost();
        using var request = sut.Sign(CommandBody);
        request.Headers.Remove("X-Signature-Timestamp");

        if (timestamp is not null)
        {
            request.Headers.TryAddWithoutValidation("X-Signature-Timestamp", timestamp);
        }

        using var response = await sut.Client.SendAsync(request);

        Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        Assert.Equal(0, sut.Handler.Calls);
    }

    private sealed class EndpointHost : IDisposable
    {
        private readonly IHost _host;
        private readonly Key _key = Key.Import(SignatureAlgorithm.Ed25519, new byte[32], KeyBlobFormat.RawPrivateKey);

        public EndpointHost(Action<IServiceCollection>? configure = null, int maxBodySize = 1024 * 1024,
            bool customHandler = true)
        {
            _host = new HostBuilder().ConfigureWebHost(web => web.UseTestServer()
                .ConfigureServices(services =>
                {
                    services.AddRouting();

                    if (customHandler)
                    {
                        services.AddSingleton<IInteractionHandler>(Handler);
                    }

                    services.AddDisconanceInteractions(options =>
                    {
                        options.PublicKey = Convert.ToHexString(_key.PublicKey.Export(KeyBlobFormat.RawPublicKey));
                        options.MaxRequestBodySize = maxBodySize;
                    });

                    configure?.Invoke(services);
                })
                .Configure(app =>
                {
                    app.UseRouting();
                    app.UseEndpoints(endpoints => endpoints.MapDisconanceInteractions("/discord"));
                })).Start();

            Client = _host.GetTestClient();
        }

        public HttpClient Client { get; }

        public RecordingHandler Handler { get; } = new();

        public void Dispose()
        {
            Client.Dispose();
            _host.Dispose();
            _key.Dispose();
        }

        public HttpRequestMessage Sign(string body, bool knownLength = true)
        {
            const string timestamp = "1700000000";
            var signature = SignatureAlgorithm.Ed25519.Sign(_key, Encoding.UTF8.GetBytes(timestamp + body));

            var request = new HttpRequestMessage(HttpMethod.Post, "/discord")
            {
                Content = knownLength ? new StringContent(body) : new UnknownLengthContent(body)
            };

            request.Headers.Add("X-Signature-Timestamp", timestamp);
            request.Headers.Add("X-Signature-Ed25519", Convert.ToHexString(signature));
            return request;
        }
    }

    private sealed class RecordingMiddleware(string name, List<string> events) : IInteractionMiddleware
    {
        public async Task<InteractionResponse?> InvokeAsync(Interaction interaction, InteractionDelegate next,
            CancellationToken cancellationToken)
        {
            events.Add(name + ":before");
            var response = await next();
            events.Add(name + ":after");
            return response;
        }
    }

    private sealed class ShortCircuitMiddleware : IInteractionMiddleware
    {
        public Task<InteractionResponse?> InvokeAsync(Interaction interaction, InteractionDelegate next,
            CancellationToken cancellationToken)
        {
            return Task.FromResult<InteractionResponse?>(new InteractionResponse
            {
                Type = InteractionCallbackType.ChannelMessageWithSource,
                Data = new InteractionMessageData { Content = "Denied" }
            });
        }
    }

    private sealed class RecordingHandler : IInteractionHandler
    {
        public int Calls { get; private set; }

        public Interaction? Received { get; private set; }

        public InteractionResponse? Response { get; set; } = new()
        {
            Type = InteractionCallbackType.ChannelMessageWithSource,
            Data = new InteractionMessageData { Content = "Pong!" }
        };

        public Task<InteractionResponse?> HandleAsync(Interaction interaction, CancellationToken cancellationToken)
        {
            Calls++;
            Received = interaction;
            return Task.FromResult(Response);
        }
    }

    private sealed class UnknownLengthContent(string body) : HttpContent
    {
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context)
        {
            return stream.WriteAsync(Encoding.UTF8.GetBytes(body)).AsTask();
        }

        protected override bool TryComputeLength(out long length)
        {
            length = 0;
            return false;
        }
    }
}