using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     GET webhooks/{application.id}/{interaction.token}/messages/{message.id}. See Discord for endpoint permissions and
///     limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#get-followup-message" />
public sealed class GetFollowupMessageRequest(Snowflake applicationId, string interactionToken, Snowflake messageId)
    : EndpointRequest<Message>(HttpMethod.Get,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}/messages/{message.id}",
            new Dictionary<string, string>
            {
                ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken,
                ["message.id"] = messageId.ToString()
            }, true))
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}