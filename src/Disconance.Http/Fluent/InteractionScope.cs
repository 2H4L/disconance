using Disconance.Http.Builders.Interactions;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     An initial callback scope. Acknowledgement lifecycle is managed by the caller.
/// </summary>
public sealed class InteractionScope(IDiscordRequestSender sender, Snowflake interactionId, string token)
{
    /// <summary>
    ///     Builds a callback, optionally requesting the callback resource.
    /// </summary>
    public CreateInteractionResponseRequestBuilder Respond()
    {
        return new CreateInteractionResponseRequestBuilder(interactionId, token, sender);
    }
}