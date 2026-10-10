namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Entity Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
public enum GuildScheduledEventEntityType
{
    /// <summary>
    ///     STAGE_INSTANCE
    /// </summary>
    StageInstance = 1,

    /// <summary>
    ///     VOICE
    /// </summary>
    Voice = 2,

    /// <summary>
    ///     EXTERNAL
    /// </summary>
    External = 3
}