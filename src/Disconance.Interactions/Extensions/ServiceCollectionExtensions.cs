using System.Reflection;
using Disconance.Http;
using Disconance.Http.Extensions;
using Disconance.Interactions.Commands;
using Disconance.Interactions.Components;
using Disconance.Interactions.Hosting;
using Disconance.Interactions.Middleware;
using Disconance.Interactions.Modals;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

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