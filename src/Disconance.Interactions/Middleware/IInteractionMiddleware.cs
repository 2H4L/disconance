using Disconance.Models.Interactions;

namespace Disconance.Interactions.Middleware;

/// <summary>
///     Wraps dispatch in registration order; the first registered middleware is outermost.
/// </summary>
public interface IInteractionMiddleware
{
    /// <summary>
    ///     Invokes the next stage or short-circuits with an initial callback. Signed PING requests bypass middleware.
    /// </summary>
    Task<InteractionResponse?> InvokeAsync(Interaction interaction, InteractionDelegate next,
        CancellationToken cancellationToken = default);
}