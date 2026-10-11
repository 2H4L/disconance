using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     PATCH applications/{application.id}/commands/{command.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
public sealed class EditGlobalApplicationCommandRequest(
    Snowflake applicationId,
    Snowflake commandId,
    EditApplicationCommandBody payload)
    : PayloadRequest<ApplicationCommand, EditApplicationCommandBody>(HttpMethod.Patch,
        new DiscordRoute("applications/{application.id}/commands/{command.id}",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["command.id"] = commandId.ToString() }), payload);