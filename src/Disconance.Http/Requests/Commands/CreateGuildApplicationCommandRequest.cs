using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     POST applications/{application.id}/guilds/{guild.id}/commands. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-guild-application-command" />
public sealed class CreateGuildApplicationCommandRequest(
    Snowflake applicationId,
    Snowflake guildId,
    ApplicationCommandDefinition payload)
    : PayloadRequest<ApplicationCommand, ApplicationCommandDefinition>(HttpMethod.Post,
        new DiscordRoute("applications/{application.id}/guilds/{guild.id}/commands",
            new Dictionary<string, string>
                { ["application.id"] = applicationId.ToString(), ["guild.id"] = guildId.ToString() }), payload);