using Disconance.Models.Users;

namespace Disconance.Models.Guilds;

/// <summary>
///     Ban data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#ban-object-ban-structure" />
public class Ban
{
    /// <summary>
    ///     The reason for the ban.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>reason</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#ban-object-ban-structure" />
    public required string? Reason { get; set; }

    /// <summary>
    ///     The banned user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#ban-object-ban-structure" />
    public required User User { get; set; }
}