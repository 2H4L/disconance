namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Recurrence Rule - N_Weekday data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
public class RecurrenceRuleWeekday
{
    /// <summary>
    ///     The week to reoccur on. 1 - 5.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>n</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required int N { get; set; }

    /// <summary>
    ///     The day within the week to reoccur on.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>day</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required RecurrenceWeekday Day { get; set; }
}