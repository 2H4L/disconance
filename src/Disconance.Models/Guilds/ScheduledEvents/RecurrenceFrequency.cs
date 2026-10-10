namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Recurrence Rule - Frequency defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
public enum RecurrenceFrequency
{
    /// <summary>
    ///     YEARLY
    /// </summary>
    Yearly = 0,

    /// <summary>
    ///     MONTHLY
    /// </summary>
    Monthly = 1,

    /// <summary>
    ///     WEEKLY
    /// </summary>
    Weekly = 2,

    /// <summary>
    ///     DAILY
    /// </summary>
    Daily = 3
}