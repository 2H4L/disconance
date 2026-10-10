namespace Disconance.Models.StageInstances;

/// <summary>
///     Privacy Level defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object-privacy-level" />
public enum StagePrivacyLevel
{
    /// <summary>
    ///     The Stage instance is visible publicly. (deprecated).
    /// </summary>
    Public = 1,

    /// <summary>
    ///     The Stage instance is visible to only guild members.
    /// </summary>
    GuildOnly = 2
}