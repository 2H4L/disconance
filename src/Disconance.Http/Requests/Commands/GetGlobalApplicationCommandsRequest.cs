using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     GET applications/{application.id}/commands. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#get-global-application-commands" />
public sealed class GetGlobalApplicationCommandsRequest(Snowflake applicationId)
    : EndpointRequest<List<ApplicationCommand>>(HttpMethod.Get,
        new DiscordRoute("applications/{application.id}/commands",
            new Dictionary<string, string> { ["application.id"] = applicationId.ToString() }))
{
    /// <summary>
    ///     Discord query field <c>with_localizations</c>; null omits the parameter.
    /// </summary>
    public bool? WithLocalizations { get; init; }

    /// <inheritdoc />
    public override IReadOnlyDictionary<string, string?> Query => new Dictionary<string, string?>
    {
        ["with_localizations"] = WithLocalizations?.ToString().ToLowerInvariant()
    };
}