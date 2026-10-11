using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     PATCH webhooks/{application.id}/{interaction.token}/messages/@original. See Discord for endpoint permissions and
///     limits.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
public sealed class EditOriginalInteractionResponseRequest(
    Snowflake applicationId,
    string interactionToken,
    EditInteractionMessageBody payload)
    : PayloadRequest<Message, EditInteractionMessageBody>(HttpMethod.Patch,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}/messages/@original",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken }, true),
        payload)
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}