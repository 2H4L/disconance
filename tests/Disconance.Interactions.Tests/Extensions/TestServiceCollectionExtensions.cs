using Disconance.Http;
using Disconance.Http.Builders.Commands;
using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Interactions.Commands;
using Disconance.Interactions.Extensions;
using Disconance.Interactions.Tests.Commands;
using Disconance.Models.Interactions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Disconance.Interactions.Tests.Extensions;

public class TestServiceCollectionExtensions
{
    [Theory]
    [InlineData("")]
    [InlineData("not-a-key")]
    [InlineData("000000000000000000000000000000000000000000000000000000000000000z")]
    public void AddDisconanceInteractions_InvalidPublicKey_RejectsConfiguration(string key)
    {
        var sut = new ServiceCollection();
        sut.AddDisconanceInteractions(options => options.PublicKey = key);
        using var provider = sut.BuildServiceProvider();

        Assert.Throws<OptionsValidationException>(() =>
            provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void AddDisconanceInteractions_InvalidBodyLimit_RejectsConfiguration(int limit)
    {
        var sut = new ServiceCollection();

        sut.AddDisconanceInteractions(options =>
        {
            options.PublicKey = new string('0', 64);
            options.MaxRequestBodySize = limit;
        });

        using var provider = sut.BuildServiceProvider();

        Assert.Throws<OptionsValidationException>(() =>
            provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value);
    }

    [Fact]
    public void AddDisconanceInteractions_RepeatedSetup_RegistersOneHttpSender()
    {
        var sut = new ServiceCollection();
        sut.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));
        sut.AddDisconanceInteractions(options => options.MaxRequestBodySize = 2048);

        using var provider = sut.BuildServiceProvider();
        var senders = provider.GetServices<IDiscordRequestSender>().ToArray();

        Assert.Single(senders);
        Assert.IsType<DiscordHttpClient>(senders[0]);
        Assert.Same(senders[0], provider.GetRequiredService<IDiscordRequestSender>());
        Assert.Equal(2048, provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value.MaxRequestBodySize);
    }

    [Fact]
    public void AddDisconanceInteractions_HttpConfiguration_ConfiguresSenderWithoutSeparateRegistration()
    {
        var sut = new ServiceCollection();

        sut.AddDisconanceInteractions(
            options => options.PublicKey = new string('0', 64),
            http =>
            {
                http.Token = "bot-token";
                http.MaxRateLimitRetries = 2;
            });

        using var provider = sut.BuildServiceProvider();
        var options = provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value;
        Assert.Equal("bot-token", options.Token);
        Assert.Equal(2, options.MaxRateLimitRetries);
        Assert.IsType<DiscordHttpClient>(provider.GetRequiredService<IDiscordRequestSender>());
    }

    [Fact]
    public void AddDisconanceInteractions_RepeatedHttpConfiguration_ComposesOptionsAndKeepsOneSender()
    {
        var sut = new ServiceCollection();

        sut.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64),
            http => http.Token = "bot-token");

        sut.AddDisconanceInteractions(_ => { }, http => http.MaxRateLimitRetries = 2);

        using var provider = sut.BuildServiceProvider();
        var options = provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value;
        Assert.Equal("bot-token", options.Token);
        Assert.Equal(2, options.MaxRateLimitRetries);
        Assert.Single(provider.GetServices<IDiscordRequestSender>());
    }

    [Fact]
    public void AddDisconanceInteractions_HttpConfiguration_PreservesExistingSender()
    {
        using var sender = new DiscordHttpClient(new DiscordHttpOptions());
        var sut = new ServiceCollection();
        sut.AddSingleton<IDiscordRequestSender>(sender);

        sut.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64),
            http => http.Token = "bot-token");

        using var provider = sut.BuildServiceProvider();
        Assert.Same(sender, Assert.Single(provider.GetServices<IDiscordRequestSender>()));
        Assert.Equal("bot-token", provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value.Token);
    }

    [Fact]
    public void AddInteractionsFromAssembly_RepeatedDiscovery_RegistersEachConcreteTypeOnce()
    {
        var sut = new ServiceCollection();
        sut.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));
        sut.AddScoped<ScopeDependency>();
        sut.AddInteractionsFromAssembly(typeof(DiscoveredCommand).Assembly);
        sut.AddInteractionsFromAssembly(typeof(DiscoveredCommand).Assembly);
        sut.AddInteraction<DiscoveredCommand>();
        using var provider = sut.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        using var scope = provider.CreateScope();

        var commands = scope.ServiceProvider.GetServices<Command>().ToArray();
        var groups = scope.ServiceProvider.GetServices<CommandGroupBase>().ToArray();
        var subcommands = scope.ServiceProvider.GetServices<Subcommand>().ToArray();

        Assert.IsType<DiscoveredCommand>(Assert.Single(commands));
        Assert.Equal(2, groups.Length);
        Assert.IsType<DiscoveredChild>(Assert.Single(subcommands));
    }

    [Fact]
    public void AddInteraction_Subcommand_RegistersParentHierarchy()
    {
        var sut = new ServiceCollection();
        sut.AddInteraction<DiscoveredChild>();
        using var provider = sut.BuildServiceProvider();
        using var scope = provider.CreateScope();

        var groups = scope.ServiceProvider.GetServices<CommandGroupBase>().ToArray();

        Assert.Contains(groups, group => group is DiscoveredGroup);
        Assert.Contains(groups, group => group is DiscoveredSubgroup);
        Assert.Equal(2, groups.Length);
    }

    [Fact]
    public async Task AddInteraction_ScopedDependency_ReusesWithinRequestAndDisposesAtScopeEnd()
    {
        var sut = new ServiceCollection();
        sut.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));
        sut.AddScoped<ScopeDependency>();
        sut.AddInteraction<DiscoveredCommand>();
        using var provider = sut.BuildServiceProvider(new ServiceProviderOptions { ValidateScopes = true });
        ScopeDependency dependency;

        using (var scope = provider.CreateScope())
        {
            dependency = scope.ServiceProvider.GetRequiredService<ScopeDependency>();

            await scope.ServiceProvider.GetRequiredService<IInteractionHandler>()
                .HandleAsync(CommandTestData.Interaction(data: CommandTestData.Data("discovered")));

            Assert.Equal(1, dependency.Calls);
            Assert.False(dependency.Disposed);
        }

        using var secondScope = provider.CreateScope();
        Assert.True(dependency.Disposed);
        Assert.NotSame(dependency, secondScope.ServiceProvider.GetRequiredService<ScopeDependency>());
    }

    [Fact]
    public void AddInteraction_UnsupportedType_RejectsRegistration()
    {
        var sut = new ServiceCollection();

        Assert.Throws<ArgumentException>(() => sut.AddInteraction<ScopeDependency>());
    }

    public sealed class ScopeDependency : IDisposable
    {
        public int Calls { get; set; }

        public bool Disposed { get; private set; }

        public void Dispose()
        {
            Disposed = true;
        }
    }

    public sealed class DiscoveredCommand(ScopeDependency dependency) : Command
    {
        public override void Configure(ApplicationCommandDefinitionBuilder command)
        {
            command.WithName("discovered").WithDescription("A discovered command.");
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken)
        {
            dependency.Calls++;
            return Task.FromResult(CommandTestData.Response("discovered"));
        }
    }

    public sealed class DiscoveredGroup : CommandGroup
    {
        public override void Configure(ApplicationCommandDefinitionBuilder group)
        {
            group.WithName("group").WithDescription("A discovered group.");
        }
    }

    public sealed class DiscoveredSubgroup : SubcommandGroup<DiscoveredGroup>
    {
        public override void Configure(ApplicationCommandOptionBuilder group)
        {
            group.WithName("subgroup").WithDescription("A discovered subgroup.");
        }
    }

    public sealed class DiscoveredChild : Subcommand<DiscoveredSubgroup>
    {
        public override void Configure(ApplicationCommandOptionBuilder command)
        {
            command.WithName("child").WithDescription("A discovered child.");
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(CommandTestData.Response("child"));
        }
    }
}