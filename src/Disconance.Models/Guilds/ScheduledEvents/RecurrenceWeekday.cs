namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Recurrence Rule - Weekday defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
public enum RecurrenceWeekday
{
    /// <summary>
    ///     MONDAY
    /// </summary>
    Monday = 0,

    /// <summary>
    ///     TUESDAY
    /// </summary>
    Tuesday = 1,

    /// <summary>
    ///     WEDNESDAY
    /// </summary>
    Wednesday = 2,

    /// <summary>
    ///     THURSDAY
    /// </summary>
    Thursday = 3,

    /// <summary>
    ///     FRIDAY
    /// </summary>
    Friday = 4,

    /// <summary>
    ///     SATURDAY
    /// </summary>
    Saturday = 5,

    /// <summary>
    ///     SUNDAY
    /// </summary>
    Sunday = 6
}