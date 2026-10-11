using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     DELETE webhooks/{application.id}/{interaction.token}/messages/{message.id}. See Discord for endpoint permissions
///     and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#delete-followup-message" />
public sealed class DeleteFollowupMessageRequest(Snowflake applicationId, string interactionToken, Snowflake messageId)
    : EndpointRequest<NoContent>(HttpMethod.Delete,
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