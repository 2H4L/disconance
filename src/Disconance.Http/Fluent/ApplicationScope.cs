using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Application-level HTTP operations, independent of interaction dispatch.
/// </summary>
public sealed class ApplicationScope(IDiscordRequestSender sender, Snowflake applicationId)
{
    /// <summary>
    ///     Global command operations.
    /// </summary>
    public GlobalCommandsScope Commands { get; } = new(sender, applicationId);

    /// <summary>
    ///     Selects a guild's application commands.
    /// </summary>
    public ApplicationGuildScope Guild(Snowflake guildId)
    {
        return new ApplicationGuildScope(sender, applicationId, guildId);
    }
}