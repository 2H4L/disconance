using Disconance.Models;
using Disconance.Models.Interactions;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     POST interactions/{interaction.id}/{interaction.token}/callback. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#create-interaction-response" />
public sealed class CreateInteractionResponseRequest(
    Snowflake interactionId,
    string interactionToken,
    InteractionResponse payload)
    : PayloadRequest<InteractionCallbackResponse, InteractionResponse>(HttpMethod.Post,
        new DiscordRoute("interactions/{interaction.id}/{interaction.token}/callback",
            new Dictionary<string, string>
                { ["interaction.id"] = interactionId.ToString(), ["interaction.token"] = interactionToken }, true),
        payload)
{
    /// <inheritdoc />
    public override bool UseAuthorization => false;

    /// <summary>
    ///     Discord query field <c>with_response</c>; null omits the parameter.
    /// </summary>
    public bool? WithResponse { get; init; }

    /// <inheritdoc />
    public override IReadOnlyDictionary<string, string?> Query => new Dictionary<string, string?>
    {
        ["with_response"] = WithResponse?.ToString().ToLowerInvariant()
    };
}