using Disconance.Models.Interactions;

namespace Disconance.Interactions;

/// <summary>
///     Dispatches an interaction to application code. Replace or decorate this service to customize routing.
/// </summary>
public interface IInteractionHandler
{
    /// <summary>
    ///     Returns an initial callback, or null when no handler matches. Cancellation follows the incoming request.
    /// </summary>
    /// <remarks>
    ///     Return a deferred callback promptly for longer work and use the HTTP sender for subsequent responses.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
    Task<InteractionResponse?> HandleAsync(Interaction interaction, CancellationToken cancellationToken = default);
}