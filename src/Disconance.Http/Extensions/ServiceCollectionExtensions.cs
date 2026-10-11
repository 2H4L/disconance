using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Disconance.Http.Extensions;

/// <summary>
///     Registers Discord HTTP services for dependency injection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <param name="services">
    ///     The application's service collection.
    /// </param>
    extension(IServiceCollection services)
    {
        /// <summary>
        ///     Configures Discord options and registers a singleton request sender unless one is already registered.
        /// </summary>
        /// <param name="configure">
        ///     Configures credentials and HTTP behavior.
        /// </param>
        /// <returns>
        ///     The service collection for further registration.
        /// </returns>
        public IServiceCollection AddDisconanceHttp(Action<DiscordHttpOptions> configure)
        {
            ArgumentNullException.ThrowIfNull(services);
            ArgumentNullException.ThrowIfNull(configure);

            services.AddOptions<DiscordHttpOptions>().Configure(configure);

            services.TryAddSingleton<IDiscordRequestSender>(provider =>
                new DiscordHttpClient(provider.GetRequiredService<IOptions<DiscordHttpOptions>>().Value));

            return services;
        }
    }
}