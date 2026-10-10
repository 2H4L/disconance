namespace Disconance.Models.Guilds;

/// <summary>
///     Explicit Content Filter Level defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-explicit-content-filter-level" />
public enum ExplicitContentFilterLevel
{
    /// <summary>
    ///     Media content will not be scanned.
    /// </summary>
    Disabled = 0,

    /// <summary>
    ///     Media content sent by members without roles will be scanned.
    /// </summary>
    MembersWithoutRoles = 1,

    /// <summary>
    ///     Media content sent by all members will be scanned.
    /// </summary>
    AllMembers = 2
}