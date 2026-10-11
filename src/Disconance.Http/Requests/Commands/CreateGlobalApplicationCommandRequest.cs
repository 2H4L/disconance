using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     POST applications/{application.id}/commands. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
public sealed class CreateGlobalApplicationCommandRequest(Snowflake applicationId, ApplicationCommandDefinition payload)
    : PayloadRequest<ApplicationCommand, ApplicationCommandDefinition>(HttpMethod.Post,
        new DiscordRoute("applications/{application.id}/commands",
            new Dictionary<string, string> { ["application.id"] = applicationId.ToString() }), payload);