using System.Net;
using Disconance.Http.Extensions;
using Disconance.Http.Fluent;
using Disconance.Http.Requests;
using Disconance.Http.Responses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Disconance.Http.Tests.Extensions;

public class TestServiceCollectionExtensions
{
    [Fact]
    public void AddDisconanceHttp_ConfiguredOptions_ResolvesSingletonSender()
    {
        var sut = new ServiceCollection();

        sut.AddDisconanceHttp(options => options.Token = "secret");

        using var provider = sut.BuildServiceProvider();
        var sender = provider.GetRequiredService<IDiscordRequestSender>();
        Assert.IsType<DiscordHttpClient>(sender);
        Assert.Same(sender, provider.GetRequiredService<IDiscordRequestSender>());
        Assert.Equal("secret", provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value.Token);
    }

    [Fact]
    public async Task AddDisconanceHttp_ExistingSender_PreservesImplementationForFluentRequests()
    {
        var sender = new RecordingSender();
        var sut = new ServiceCollection();
        sut.AddSingleton<IDiscordRequestSender>(sender);

        sut.AddDisconanceHttp(options => options.Token = "secret");

        using var provider = sut.BuildServiceProvider();
        await provider.GetRequiredService<IDiscordRequestSender>().CurrentUser().SendAsync();
        Assert.Equal(1, sender.Calls);
        Assert.Single(provider.GetServices<IDiscordRequestSender>());
    }

    [Fact]
    public void AddDisconanceHttp_RepeatedRegistration_ComposesOptionsWithoutDuplicatingSender()
    {
        var sut = new ServiceCollection();
        sut.AddDisconanceHttp(options => options.Token = "secret");

        sut.AddDisconanceHttp(options => options.MaxRateLimitRetries = 2);

        using var provider = sut.BuildServiceProvider();
        var options = provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value;
        Assert.Equal("secret", options.Token);
        Assert.Equal(2, options.MaxRateLimitRetries);
        Assert.Single(provider.GetServices<IDiscordRequestSender>());
    }

    private sealed class RecordingSender : IDiscordRequestSender
    {
        public int Calls { get; private set; }

        public Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request,
            CancellationToken cancellationToken = default)
        {
            Calls++;

            return Task.FromResult(new DiscordResponse<T>
            {
                StatusCode = HttpStatusCode.NoContent,
                HasBody = false,
                Headers = new Dictionary<string, string[]>()
            });
        }
    }
}