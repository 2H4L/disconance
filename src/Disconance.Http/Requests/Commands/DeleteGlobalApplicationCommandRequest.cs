using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     DELETE applications/{application.id}/commands/{command.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#delete-global-application-command" />
public sealed class DeleteGlobalApplicationCommandRequest(Snowflake applicationId, Snowflake commandId)
    : EndpointRequest<NoContent>(HttpMethod.Delete,
        new DiscordRoute("applications/{application.id}/commands/{command.id}",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["command.id"] = commandId.ToString() }));