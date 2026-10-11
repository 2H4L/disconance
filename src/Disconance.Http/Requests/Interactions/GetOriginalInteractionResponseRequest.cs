using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     GET webhooks/{application.id}/{interaction.token}/messages/@original. See Discord for endpoint permissions and
///     limits.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#get-original-interaction-response" />
public sealed class GetOriginalInteractionResponseRequest(Snowflake applicationId, string interactionToken)
    : EndpointRequest<Message>(HttpMethod.Get,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}/messages/@original",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken }, true))
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}