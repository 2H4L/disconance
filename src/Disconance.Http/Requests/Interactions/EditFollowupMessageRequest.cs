using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     PATCH webhooks/{application.id}/{interaction.token}/messages/{message.id}. See Discord for endpoint permissions and
///     limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-followup-message" />
public sealed class EditFollowupMessageRequest(
    Snowflake applicationId,
    string interactionToken,
    Snowflake messageId,
    EditInteractionMessageBody payload)
    : PayloadRequest<Message, EditInteractionMessageBody>(HttpMethod.Patch,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}/messages/{message.id}",
            new Dictionary<string, string>
            {
                ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken,
                ["message.id"] = messageId.ToString()
            }, true), payload)
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}