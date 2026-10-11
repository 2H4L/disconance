using Disconance.Http.Builders.Interactions;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Token-authenticated operations for an acknowledged interaction.
/// </summary>
public sealed class InteractionWebhookScope(IDiscordRequestSender sender, Snowflake applicationId, string token)
{
    /// <summary>
    ///     Followup operations.
    /// </summary>
    public FollowupMessagesScope Followups { get; } = new(sender, applicationId, token);

    /// <summary>
    ///     Gets the original response.
    /// </summary>
    public GetOriginalInteractionResponseRequestBuilder GetOriginalResponse()
    {
        return new GetOriginalInteractionResponseRequestBuilder(applicationId, token, sender);
    }

    /// <summary>
    ///     Edits the original response, including completing a deferred message.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder EditOriginalResponse()
    {
        return new EditOriginalInteractionResponseRequestBuilder(applicationId, token, sender);
    }

    /// <summary>
    ///     Deletes the original response.
    /// </summary>
    public DeleteOriginalInteractionResponseRequestBuilder DeleteOriginalResponse()
    {
        return new DeleteOriginalInteractionResponseRequestBuilder(applicationId, token, sender);
    }
}