using System.Text;
using System.Text.Json;
using Disconance.Http;
using Disconance.Http.Builders.Commands;
using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Interactions.Commands;
using Disconance.Interactions.Extensions;
using Disconance.Interactions.Tests.Commands;
using Disconance.Models;
using Disconance.Models.Interactions;
using Disconance.Models.Users;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Disconance.Interactions.Tests.Extensions;

public class TestServiceCollectionExtensions
{
    [Fact]
    public void AddDisconanceInteractions_DefaultSection_BindsMergedConfigurationAndPreservesDiscordJson()
    {
        using var json = new MemoryStream(Encoding.UTF8.GetBytes("""
            {
              "Discord": {
                "ApplicationId": "18446744073709551615",
                "PublicKey": "0000000000000000000000000000000000000000000000000000000000000000",
                "BotToken": "original-token",
                "MaxRequestBodySize": 4096,
                "Http": {
                  "MaxRateLimitRetries": 2,
                  "RequestTimeout": "00:00:05"
                }
              }
            }
            """));

        using var configuration = (ConfigurationRoot) new ConfigurationBuilder().AddJsonStream(json)
            .AddInMemoryCollection(new Dictionary<string, string?> { ["Discord:BotToken"] = "overridden-token" })
            .Build();

        var sut = new ServiceCollection();
        sut.AddSingleton<IConfiguration>(configuration);

        sut.AddDisconanceInteractions();

        using var provider = sut.BuildServiceProvider();
        var interactions = provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value;
        var http = provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value;
        Assert.Equal(new Snowflake(ulong.MaxValue), interactions.ApplicationId);
        Assert.Equal(new string('0', 64), interactions.PublicKey);
        Assert.Equal(4096, interactions.MaxRequestBodySize);
        Assert.Equal("overridden-token", http.Token);
        Assert.Equal(2, http.MaxRateLimitRetries);
        Assert.Equal(TimeSpan.FromSeconds(5), http.RequestTimeout);

        Assert.Equal("{\"id\":\"18446744073709551615\",\"global_name\":null}",
            JsonSerializer.Serialize(new PartialUser { Id = new Snowflake(ulong.MaxValue), GlobalName = null },
                http.SerializerOptions));
    }

    [Fact]
    public void AddDisconanceInteractions_CustomSection_ReadsSelectedSection()
    {
        using var configuration = (ConfigurationRoot) new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["Bot:ApplicationId"] = "42",
            ["Bot:PublicKey"] = new string('1', 64),
            ["Bot:BotToken"] = "bot-token",
            ["Discord:ApplicationId"] = "invalid"
        }).Build();

        var sut = new ServiceCollection();
        sut.AddSingleton<IConfiguration>(configuration);

        sut.AddDisconanceInteractions("Bot");

        using var provider = sut.BuildServiceProvider();
        var options = provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value;
        Assert.Equal(new Snowflake(42), options.ApplicationId);
        Assert.Equal(new string('1', 64), options.PublicKey);
        Assert.Equal("bot-token", provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value.Token);
    }

    [Theory]
    [InlineData("")]
    [InlineData("0")]
    [InlineData("-1")]
    [InlineData("+1")]
    [InlineData(" 42")]
    [InlineData("18446744073709551616")]
    [InlineData("not-an-id")]
    public void AddDisconanceInteractions_InvalidConfiguredApplicationId_RejectsConfiguration(string applicationId)
    {
        using var configuration = (ConfigurationRoot) new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["Discord:ApplicationId"] = applicationId,
            ["Discord:PublicKey"] = new string('0', 64)
        }).Build();

        var sut = new ServiceCollection();
        sut.AddSingleton<IConfiguration>(configuration);
        sut.AddDisconanceInteractions();
        using var provider = sut.BuildServiceProvider();

        var exception = Assert.Throws<OptionsValidationException>(() =>
            provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value);

        Assert.Contains("Discord:ApplicationId", exception.Message);
    }

    [Fact]
    public void AddDisconanceInteractions_ApplicationIdAndTokenOmitted_AllowsReceivingInteractions()
    {
        using var configuration = (ConfigurationRoot) new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["Discord:PublicKey"] = new string('0', 64)
        }).Build();

        var sut = new ServiceCollection();
        sut.AddSingleton<IConfiguration>(configuration);

        sut.AddDisconanceInteractions();

        using var provider = sut.BuildServiceProvider();
        Assert.Equal(default, provider.GetRequiredService<IOptions<DiscordInteractionOptions>>().Value.ApplicationId);
        Assert.Null(provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value.Token);
    }

    [Fact]
    public async Task RegisterGlobalCommandsOnStartup_ConfiguredApplication_DeduplicatesExplicitAndConfiguredTargets()
    {
        var registration = new RecordingRegistration();
        registration.Continue.SetResult();
        var builder = Host.CreateApplicationBuilder();

        builder.Configuration.AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["Discord:ApplicationId"] = "42",
            ["Discord:PublicKey"] = new string('0', 64)
        });

        builder.Services.AddScoped<ICommandRegistrationService>(_ => registration);

        builder.Services.AddDisconanceInteractions()
            .RegisterGlobalCommandsOnStartup()
            .RegisterGlobalCommandsOnStartup(new Snowflake(42))
            .RegisterGuildCommandsOnStartup(new Snowflake(84))
            .RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));

        using var sut = builder.Build();

        await sut.StartAsync();

        Assert.Equal(["global:42", "guild:42:84"], registration.Targets);
        Assert.True(registration.Disposed);
    }

    [Fact]
    public async Task RegisterGlobalCommandsOnStartup_ApplicationIdMissing_FailsBeforePublishingAnyTargets()
    {
        var registration = new RecordingRegistration();
        registration.Continue.SetResult();
        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddScoped<ICommandRegistrationService>(_ => registration);

        builder.Services.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64))
            .RegisterGlobalCommandsOnStartup(new Snowflake(42))
            .RegisterGlobalCommandsOnStartup();

        using var sut = builder.Build();

        var exception = await Assert.ThrowsAsync<OptionsValidationException>(() => sut.StartAsync());

        Assert.Contains("ApplicationId", exception.Message);
        Assert.Empty(registration.Targets);
    }

    [Fact]
    public async Task AddDisconanceInteractions_StartupRegistrationNotRequested_DoesNotResolveRegistrationService()
    {
        var builder = Host.CreateApplicationBuilder();
        builder.Services.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64));

        builder.Services.AddScoped<ICommandRegistrationService>(_ =>
            throw new InvalidOperationException("Registration was not requested."));

        using var sut = builder.Build();

        await sut.StartAsync();
    }

    [Fact]
    public async Task RegisterGlobalCommandsOnStartup_CustomRegistrationAndMultipleTargets_HostAwaitsScopedRegistration()
    {
        var registration = new RecordingRegistration();
        var earlierService = new StartupObserver();
        var builder = Host.CreateApplicationBuilder();
        builder.Services.Configure<HostOptions>(options => options.ServicesStartConcurrently = true);
        builder.Services.AddSingleton<IHostedService>(earlierService);
        builder.Services.AddScoped<ICommandRegistrationService>(_ => registration);

        builder.Services.AddDisconanceInteractions(options => options.PublicKey = new string('0', 64))
            .RegisterGlobalCommandsOnStartup(new Snowflake(42))
            .RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84))
            .RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(85))
            .RegisterGuildCommandsOnStartup(new Snowflake(43), new Snowflake(84))
            .RegisterGuildCommandsOnStartup(new Snowflake(42), new Snowflake(84));

        using var sut = builder.Build();

        var startup = sut.StartAsync();
        await registration.Started.Task.WaitAsync(TimeSpan.FromSeconds(5));
        var awaitedRegistration = !startup.IsCompleted;
        var startedOtherServices = earlierService.Started;
        registration.Continue.SetResult();
        await startup;

        Assert.True(awaitedRegistration);
        Assert.False(startedOtherServices);
        Assert.True(earlierService.Started);
        Assert.Equal(["global:42", "guild:42:84", "guild:42:85", "guild:43:84"], registration.Targets);
        Assert.True(registration.Disposed);
    }

    [Fact]
    public void RegisterGlobalCommandsOnStartup_ZeroApplicationId_RejectsRegistration()
    {
        var sut = new ServiceCollection();

        Assert.Throws<ArgumentOutOfRangeException>(() => sut.RegisterGlobalCommandsOnStartup(default));
    }

    [Theory]
    [InlineData(0UL, 84UL)]
    [InlineData(42UL, 0UL)]
    public void RegisterGuildCommandsOnStartup_ZeroIdentifier_RejectsRegistration(ulong applicationId, ulong guildId)
    {
        var sut = new ServiceCollection();

        Assert.Throws<ArgumentOutOfRangeException>(() =>
            sut.RegisterGuildCommandsOnStartup(new Snowflake(applicationId), new Snowflake(guildId)));
    }

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

    private sealed class StartupObserver : IHostedService
    {
        internal bool Started { get; private set; }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Started = true;
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }

    private sealed class RecordingRegistration : ICommandRegistrationService, IAsyncDisposable
    {
        internal List<string> Targets { get; } = [];

        internal TaskCompletionSource Started { get; } = new(TaskCreationOptions.RunContinuationsAsynchronously);

        internal TaskCompletionSource Continue { get; } = new(TaskCreationOptions.RunContinuationsAsynchronously);

        internal bool Disposed { get; private set; }

        public async Task RegisterGlobalCommandsAsync(Snowflake applicationId,
            CancellationToken cancellationToken = default)
        {
            Targets.Add($"global:{applicationId}");
            Started.SetResult();
            await Continue.Task.WaitAsync(cancellationToken);
        }

        public Task RegisterGuildCommandsAsync(Snowflake applicationId, Snowflake guildId,
            CancellationToken cancellationToken = default)
        {
            Targets.Add($"guild:{applicationId}:{guildId}");
            return Task.CompletedTask;
        }

        public ValueTask DisposeAsync()
        {
            Disposed = true;
            return ValueTask.CompletedTask;
        }
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
