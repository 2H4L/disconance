using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     GET applications/{application.id}/commands/{command.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#get-global-application-command" />
public sealed class GetGlobalApplicationCommandRequest(Snowflake applicationId, Snowflake commandId)
    : EndpointRequest<ApplicationCommand>(HttpMethod.Get,
        new DiscordRoute("applications/{application.id}/commands/{command.id}",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["command.id"] = commandId.ToString() }));