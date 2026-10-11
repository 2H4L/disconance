using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     POST webhooks/{application.id}/{interaction.token}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#create-followup-message" />
public sealed class CreateFollowupMessageRequest(
    Snowflake applicationId,
    string interactionToken,
    CreateFollowupMessageBody payload)
    : PayloadRequest<Message, CreateFollowupMessageBody>(HttpMethod.Post,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken }, true),
        payload)
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}