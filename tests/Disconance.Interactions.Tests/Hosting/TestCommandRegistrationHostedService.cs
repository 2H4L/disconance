using System.Net;
using Disconance.Http;
using Disconance.Http.Builders.Commands;
using Disconance.Http.Requests;
using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Interactions.Commands;
using Disconance.Interactions.Extensions;
using Disconance.Models;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Disconance.Interactions.Tests.Hosting;

public class TestCommandRegistrationHostedService
{
    [Fact]
    public async Task StartingAsync_GlobalAndMultipleGuilds_PublishesEachTargetOnceWithinDisposedScope()
    {
        var sender = new RecordingSender();
        var dependency = new AsyncDependency();
        var services = CreateServices(sender, dependency);
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        services.RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));
        services.RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(85));
        services.RegisterGuildCommandsOnStartup(new Snowflake(43), new Snowflake(84));
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        services.RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));
        using var cancellation = new CancellationTokenSource();

        await sut.StartingAsync(cancellation.Token);

        Assert.Equal(4, sender.Requests.Count);
        Assert.IsType<CreateGlobalApplicationCommandRequest>(sender.Requests[0]);
        Assert.All(sender.Requests.Skip(1), request => Assert.IsType<CreateGuildApplicationCommandRequest>(request));
        Assert.All(sender.Requests, request =>
            Assert.Equal("ping", Assert.IsType<ApplicationCommandDefinition>(request.Body).Name));

        Assert.Equal(1, dependency.Configurations);
        Assert.True(dependency.Disposed);
        Assert.Equal(cancellation.Token, sender.Cancellation);
    }

    [Fact]
    public async Task StartingAsync_RegistrationFails_PropagatesFailureAndDisposesScope()
    {
        var failure = new InvalidOperationException("Registration failed.");
        var sender = new RecordingSender { Failure = failure };
        var dependency = new AsyncDependency();
        var services = CreateServices(sender, dependency);
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        services.RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => sut.StartingAsync(default));

        Assert.Same(failure, exception);
        Assert.Single(sender.Requests);
        Assert.True(dependency.Disposed);
    }

    [Fact]
    public async Task StartingAsync_AlreadyCancelled_DoesNotConstructCommandsOrSend()
    {
        var sender = new RecordingSender();
        var dependency = new AsyncDependency();
        var services = CreateServices(sender, dependency);
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => sut.StartingAsync(cancellation.Token));

        Assert.Empty(sender.Requests);
        Assert.Equal(0, dependency.Configurations);
        Assert.False(dependency.Disposed);
    }

    [Fact]
    public async Task StartingAsync_CancelledAfterFirstTarget_StopsRegistrationAndDisposesScope()
    {
        using var cancellation = new CancellationTokenSource();
        var sender = new RecordingSender { OnSend = cancellation.Cancel };
        var dependency = new AsyncDependency();
        var services = CreateServices(sender, dependency);
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        services.RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() => sut.StartingAsync(cancellation.Token));

        Assert.Single(sender.Requests);
        Assert.True(dependency.Disposed);
    }

    [Fact]
    public async Task StartingAsync_NoCommands_DoesNotSend()
    {
        var sender = new RecordingSender();
        var services = new ServiceCollection();
        services.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));
        services.AddSingleton<IDiscordRequestSender>(sender);
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));

        await sut.StartingAsync(default);

        Assert.Empty(sender.Requests);
    }

    [Fact]
    public async Task StopAsync_AfterStartup_DoesNotPublishAgain()
    {
        var sender = new RecordingSender();
        var services = CreateServices(sender, new AsyncDependency());
        services.RegisterGlobalCommandsOnStartup(new Snowflake(42));
        await using var provider = services.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        var sut = Assert.IsAssignableFrom<IHostedLifecycleService>(Assert.Single(provider.GetServices<IHostedService>()));
        await sut.StartingAsync(default);
        sender.Requests.Clear();

        await sut.StopAsync(default);

        Assert.Empty(sender.Requests);
    }

    private static ServiceCollection CreateServices(RecordingSender sender, AsyncDependency dependency)
    {
        var services = new ServiceCollection();
        services.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));
        services.AddSingleton<IDiscordRequestSender>(sender);
        services.AddScoped(_ => dependency);
        services.AddInteraction<StartupCommand>();
        return services;
    }

    private sealed class AsyncDependency : IAsyncDisposable
    {
        internal int Configurations { get; set; }

        internal bool Disposed { get; private set; }

        public ValueTask DisposeAsync()
        {
            Disposed = true;
            return ValueTask.CompletedTask;
        }
    }

    private sealed class StartupCommand(AsyncDependency dependency) : Command
    {
        public override void Configure(ApplicationCommandDefinitionBuilder command)
        {
            dependency.Configurations++;
            command.WithName("ping").WithDescription("Replies with Pong.");
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException();
        }
    }

    private sealed class RecordingSender : IDiscordRequestSender
    {
        internal List<IDiscordRequest<ApplicationCommand>> Requests { get; } = [];

        internal CancellationToken Cancellation { get; private set; }

        internal Exception? Failure { get; init; }

        internal Action? OnSend { get; init; }

        public Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request,
            CancellationToken cancellationToken = default)
        {
            Requests.Add(Assert.IsAssignableFrom<IDiscordRequest<ApplicationCommand>>(request));
            Cancellation = cancellationToken;
            OnSend?.Invoke();

            return Failure is null
                ? Task.FromResult(new DiscordResponse<T> { StatusCode = HttpStatusCode.OK, HasBody = false })
                : Task.FromException<DiscordResponse<T>>(Failure);
        }
    }
}
