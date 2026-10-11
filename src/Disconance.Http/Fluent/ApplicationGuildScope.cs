using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     A guild's application registration scope.
/// </summary>
public sealed class ApplicationGuildScope(IDiscordRequestSender sender, Snowflake applicationId, Snowflake guildId)
{
    /// <summary>
    ///     Guild command operations.
    /// </summary>
    public GuildCommandsScope Commands { get; } = new(sender, applicationId, guildId);
}