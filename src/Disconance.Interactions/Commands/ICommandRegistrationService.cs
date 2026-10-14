using Disconance.Models;

namespace Disconance.Interactions.Commands;

/// <summary>
///     Explicitly upserts registered definitions using the configured HTTP sender. Never deletes other commands.
/// </summary>
public interface ICommandRegistrationService
{
    /// <summary>
    ///     Publishes all registered command definitions globally for the supplied application.
    /// </summary>
    Task RegisterGlobalCommandsAsync(Snowflake applicationId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Publishes all registered command definitions to the supplied guild.
    /// </summary>
    Task RegisterGuildCommandsAsync(Snowflake applicationId, Snowflake guildId,
        CancellationToken cancellationToken = default);
}