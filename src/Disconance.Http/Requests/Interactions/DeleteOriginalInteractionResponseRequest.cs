using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     DELETE webhooks/{application.id}/{interaction.token}/messages/@original. See Discord for endpoint permissions and
///     limits.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#delete-original-interaction-response" />
public sealed class DeleteOriginalInteractionResponseRequest(Snowflake applicationId, string interactionToken)
    : EndpointRequest<NoContent>(HttpMethod.Delete,
        new DiscordRoute("webhooks/{application.id}/{interaction.token}/messages/@original",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["interaction.token"] = interactionToken }, true))
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;
}