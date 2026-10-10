namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Permission Type defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
public enum ApplicationCommandPermissionType
{
    /// <summary>
    ///     ROLE
    /// </summary>
    Role = 1,

    /// <summary>
    ///     USER
    /// </summary>
    User = 2,

    /// <summary>
    ///     CHANNEL
    /// </summary>
    Channel = 3
}