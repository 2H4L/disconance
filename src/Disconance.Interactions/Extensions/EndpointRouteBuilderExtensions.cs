using Disconance.Interactions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Disconance.Interactions.Extensions;

/// <summary>
///     Hosts Discord interactions in ASP.NET Core.
/// </summary>
public static class EndpointRouteBuilderExtensions
{
    /// <param name="endpoints">
    ///     The application or route group receiving the endpoint.
    /// </param>
    extension(IEndpointRouteBuilder endpoints)
    {
        /// <summary>
        ///     Maps a POST endpoint authenticated by Discord's signature, independently of cookie or bearer authentication.
        /// </summary>
        /// <param name="pattern">
        ///     The route pattern, relative to a route group when applicable.
        /// </param>
        /// <returns>
        ///     The endpoint convention builder for standard ASP.NET Core customization.
        /// </returns>
        public RouteHandlerBuilder MapDisconanceInteractions(string pattern = "/api/interactions")
        {
            ArgumentNullException.ThrowIfNull(endpoints);
            ArgumentException.ThrowIfNullOrWhiteSpace(pattern);

            return endpoints.MapPost(pattern, (Func<HttpContext, Task<IResult>>) Handler)
                .AllowAnonymous()
                .DisableAntiforgery();

            Task<IResult> Handler(HttpContext context)
            {
                return context.RequestServices.GetRequiredService<InteractionEndpoint>().HandleAsync(context);
            }
        }
    }
}