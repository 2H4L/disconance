using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     PUT applications/{application.id}/commands. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/application-commands#bulk-overwrite-global-application-commands" />
public sealed class BulkOverwriteGlobalApplicationCommandsRequest(
    Snowflake applicationId,
    List<ApplicationCommandDefinition> payload)
    : PayloadRequest<List<ApplicationCommand>, List<ApplicationCommandDefinition>>(HttpMethod.Put,
        new DiscordRoute("applications/{application.id}/commands",
            new Dictionary<string, string> { ["application.id"] = applicationId.ToString() }), payload);