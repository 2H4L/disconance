namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Age-Restriction Level defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-nsfw-level" />
public enum GuildNsfwLevel
{
    /// <summary>
    ///     DEFAULT
    /// </summary>
    Default = 0,

    /// <summary>
    ///     EXPLICIT
    /// </summary>
    Explicit = 1,

    /// <summary>
    ///     SAFE
    /// </summary>
    Safe = 2,

    /// <summary>
    ///     AGE_RESTRICTED
    /// </summary>
    AgeRestricted = 3
}