using System.Reflection;
using Disconance.Http;
using Disconance.Http.Extensions;
using Disconance.Interactions.Commands;
using Disconance.Interactions.Components;
using Disconance.Interactions.Hosting;
using Disconance.Interactions.Middleware;
using Disconance.Interactions.Modals;
using Disconance.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Disconance.Interactions.Extensions;

/// <summary>
///     Registers interaction services and scoped application handlers.
/// </summary>
public static class ServiceCollectionExtensions
{
    private static readonly Type[] Contracts =
    [
        typeof(Command), typeof(CommandGroupBase), typeof(Subcommand),
        typeof(IMessageComponentHandler), typeof(IModalSubmitHandler)
    ];

    /// <param name="services">
    ///     The application's service collection.
    /// </param>
    extension(IServiceCollection services)
    {
        /// <summary>
        ///     Configures interactions and HTTP from the application's IConfiguration service.
        ///     The default section is Discord. Discord JSON serialization is configured internally.
        /// </summary>
        /// <remarks>
        ///     Reads ApplicationId, PublicKey, BotToken, and MaxRequestBodySize from the selected section.
        ///     Optional HTTP transport settings belong in its Http child section. ApplicationId accepts unsigned
        ///     decimal strings across the full 64-bit range. Startup command registration remains explicit.
        /// </remarks>
        /// <param name="configurationSection">
        ///     The configuration section containing settings from appsettings, user secrets, or other providers.
        /// </param>
        /// <returns>
        ///     The service collection for additional interaction setup and registration targets.
        /// </returns>
        public IServiceCollection AddDisconanceInteractions(string configurationSection = "Discord")
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentException.ThrowIfNullOrWhiteSpace(configurationSection);
            services.AddDisconanceInteractions(_ => { });

            services.AddOptions<DiscordInteractionOptions>().Configure<IConfiguration>((options, configuration) =>
            {
                var section = configuration.GetRequiredSection(configurationSection);
                var applicationId = section[nameof(DiscordInteractionOptions.ApplicationId)];

                if (applicationId is not null)
                {
                    if (!Snowflake.TryParse(applicationId, out var parsed) || parsed.Value == 0)
                    {
                        throw new OptionsValidationException(Options.DefaultName, typeof(DiscordInteractionOptions),
                            [$"{section.Path}:ApplicationId must be a nonzero unsigned decimal snowflake."]);
                    }

                    options.ApplicationId = parsed;
                }

                options.PublicKey = section[nameof(DiscordInteractionOptions.PublicKey)] ?? options.PublicKey;

                options.MaxRequestBodySize = section.GetValue<int?>(nameof(DiscordInteractionOptions.MaxRequestBodySize))
                                             ?? options.MaxRequestBodySize;
            });

            services.AddOptions<DiscordHttpOptions>().Configure<IConfiguration>((options, configuration) =>
            {
                var section = configuration.GetRequiredSection(configurationSection);
                section.GetSection("Http").Bind(options);
                options.Token = section["BotToken"] ?? options.Token;
            });

            return services;
        }

        /// <summary>
        ///     Adds HTTP services, the signed endpoint, and dispatch services, preserving existing senders and handlers.
        /// </summary>
        /// <param name="configure">
        ///     Configures the interaction endpoint.
        /// </param>
        /// <param name="configureHttp">
        ///     Optionally configures HTTP credentials and behavior through AddDisconanceHttp.
        ///     Separate HTTP registration is not required.
        /// </param>
        /// <returns>
        ///     The service collection for further registration.
        /// </returns>
        public IServiceCollection AddDisconanceInteractions(Action<DiscordInteractionOptions> configure,
            Action<DiscordHttpOptions>? configureHttp = null)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configure);

            services.AddOptions<DiscordInteractionOptions>()
                .Configure(configure)
                .Validate(options => options.PublicKey is { Length: 64 } key && key.All(char.IsAsciiHexDigit),
                    "PublicKey must contain exactly 64 hexadecimal characters.")
                .Validate(options => options.MaxRequestBodySize > 0, "MaxRequestBodySize must be positive.")
                .ValidateOnStart();

            services.AddDisconanceHttp(configureHttp ?? (_ => { }));
            services.TryAddSingleton<InteractionEndpoint>();
            services.TryAddScoped<CommandCatalog>();
            services.TryAddScoped<IInteractionHandler, DefaultInteractionHandler>();
            services.TryAddScoped<ICommandRegistrationService, CommandRegistrationService>();
            return services;
        }

        /// <summary>
        ///     Publishes discovered command definitions globally during host startup using the configured ApplicationId.
        ///     Requires AddDisconanceInteractions. Registration failures fail startup.
        /// </summary>
        /// <returns>
        ///     The service collection for additional interaction setup and registration targets.
        /// </returns>
        public IServiceCollection RegisterGlobalCommandsOnStartup()
        {
            ArgumentNullException.ThrowIfNull(services);
            services.AddSingleton(new CommandRegistrationTarget(null, null));

            services.TryAddEnumerable(
                ServiceDescriptor.Singleton<IHostedService, CommandRegistrationHostedService>());

            return services;
        }

        /// <summary>
        ///     Publishes discovered command definitions globally during host startup.
        ///     Requires AddDisconanceInteractions. Repeated targets are published once per startup.
        /// </summary>
        /// <remarks>
        ///     Registration uses the configured ICommandRegistrationService within an internally managed scope.
        ///     Commands are created or updated without deleting other commands. Registration failures fail startup.
        /// </remarks>
        /// <param name="applicationId">
        ///     The Discord application receiving the command definitions.
        /// </param>
        /// <returns>
        ///     The service collection for additional interaction setup and registration targets.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The application ID is zero.
        /// </exception>
        public IServiceCollection RegisterGlobalCommandsOnStartup(Snowflake applicationId)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentOutOfRangeException.ThrowIfZero(applicationId.Value);
            services.AddSingleton(new CommandRegistrationTarget(applicationId, null));

            services.TryAddEnumerable(
                ServiceDescriptor.Singleton<IHostedService, CommandRegistrationHostedService>());

            return services;
        }

        /// <summary>
        ///     Publishes discovered command definitions to a guild during host startup using the configured ApplicationId.
        ///     Requires AddDisconanceInteractions. Repeat for additional guilds or combine with global registration.
        /// </summary>
        /// <param name="guildId">
        ///     The guild receiving this registration. Other targets are configured independently.
        /// </param>
        /// <returns>
        ///     The service collection for additional interaction setup and registration targets.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The guild ID is zero.
        /// </exception>
        public IServiceCollection RegisterGuildCommandsOnStartup(Snowflake guildId)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentOutOfRangeException.ThrowIfZero(guildId.Value);
            services.AddSingleton(new CommandRegistrationTarget(null, guildId));

            services.TryAddEnumerable(
                ServiceDescriptor.Singleton<IHostedService, CommandRegistrationHostedService>());

            return services;
        }

        /// <summary>
        ///     Publishes discovered command definitions to a guild during host startup.
        ///     Requires AddDisconanceInteractions. Repeat for additional guilds or combine with global registration.
        /// </summary>
        /// <remarks>
        ///     Repeated targets are published once per startup using an internally managed scope.
        ///     Commands are created or updated without deleting other commands. Registration failures fail startup.
        /// </remarks>
        /// <param name="applicationId">
        ///     The Discord application receiving the command definitions.
        /// </param>
        /// <param name="guildId">
        ///     The guild receiving this registration. Other targets are configured independently.
        /// </param>
        /// <returns>
        ///     The service collection for additional interaction setup and registration targets.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     The application ID or guild ID is zero.
        /// </exception>
        public IServiceCollection RegisterGuildCommandsOnStartup(Snowflake applicationId, Snowflake guildId)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentOutOfRangeException.ThrowIfZero(applicationId.Value);
            ArgumentOutOfRangeException.ThrowIfZero(guildId.Value);
            services.AddSingleton(new CommandRegistrationTarget(applicationId, guildId));

            services.TryAddEnumerable(
                ServiceDescriptor.Singleton<IHostedService, CommandRegistrationHostedService>());

            return services;
        }

        /// <summary>
        ///     Registers a command, group, component, or modal as scoped, including its declared parent groups.
        ///     Repeated registration of the same type is ignored.
        /// </summary>
        /// <typeparam name="TInteraction">
        ///     A concrete interaction implementation with a public constructor.
        /// </typeparam>
        public IServiceCollection AddInteraction<TInteraction>() where TInteraction : class
        {
            ArgumentNullException.ThrowIfNull(services);
            Register(services, typeof(TInteraction));
            return services;
        }

        /// <summary>
        ///     Discovers public concrete commands, groups, components, and modals in the supplied assembly.
        ///     Middleware is registered explicitly to preserve intentional ordering.
        /// </summary>
        public IServiceCollection AddInteractionsFromAssembly(Assembly assembly)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(assembly);

            foreach (var type in assembly.GetExportedTypes().Where(IsInteraction)
                         .OrderBy(type => type.FullName, StringComparer.Ordinal))
            {
                Register(services, type);
            }

            return services;
        }

        /// <summary>
        ///     Adds scoped middleware in outermost-first order. Repeated registration of a type is ignored.
        /// </summary>
        /// <typeparam name="TMiddleware">
        ///     The middleware implementation.
        /// </typeparam>
        public IServiceCollection AddInteractionMiddleware<TMiddleware>()
            where TMiddleware : class, IInteractionMiddleware
        {
            ArgumentNullException.ThrowIfNull(services);
            services.TryAddEnumerable(ServiceDescriptor.Scoped<IInteractionMiddleware, TMiddleware>());
            return services;
        }
    }

    private static bool IsInteraction(Type type)
    {
        return type is { IsClass: true, IsAbstract: false, ContainsGenericParameters: false } &&
               Contracts.Any(contract => contract.IsAssignableFrom(type));
    }

    private static void Register(IServiceCollection services, Type type)
    {
        if (!IsInteraction(type))
        {
            throw new ArgumentException($"{type.Name} must be a concrete command, group, component, or modal.",
                nameof(type));
        }

        for (var ancestor = type.BaseType; ancestor is not null; ancestor = ancestor.BaseType)
        {
            if (!ancestor.IsGenericType ||
                (ancestor.GetGenericTypeDefinition() != typeof(Subcommand<>) &&
                 ancestor.GetGenericTypeDefinition() != typeof(SubcommandGroup<>)))
            {
                continue;
            }

            Register(services, ancestor.GenericTypeArguments[0]);
            break;
        }

        foreach (var contract in Contracts.Where(contract => contract.IsAssignableFrom(type)))
        {
            services.TryAddEnumerable(ServiceDescriptor.Scoped(contract, type));
        }
    }
}
