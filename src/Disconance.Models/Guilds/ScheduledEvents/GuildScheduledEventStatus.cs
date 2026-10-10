namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Status defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
public enum GuildScheduledEventStatus
{
    /// <summary>
    ///     SCHEDULED
    /// </summary>
    Scheduled = 1,

    /// <summary>
    ///     ACTIVE
    /// </summary>
    Active = 2,

    /// <summary>
    ///     COMPLETED
    /// </summary>
    Completed = 3,

    /// <summary>
    ///     CANCELED
    /// </summary>
    Canceled = 4
}