namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Recurrence Rule data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
public class GuildScheduledEventRecurrenceRule
{
    /// <summary>
    ///     Starting time of the recurrence interval.
    /// </summary>
    /// <remarks>Discord field: <c>start</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required DateTimeOffset Start { get; set; }

    /// <summary>
    ///     Ending time of the recurrence interval.
    /// </summary>
    /// <remarks>Discord field: <c>end</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required DateTimeOffset? End { get; set; }

    /// <summary>
    ///     How often the event occurs.
    /// </summary>
    /// <remarks>Discord field: <c>frequency</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required RecurrenceFrequency Frequency { get; set; }

    /// <summary>
    ///     The spacing between the events, defined by <c>frequency</c> . For example, <c>frequency</c> of <c>WEEKLY</c>
    ///     and an <c>interval</c> of <c>2</c> would be "every-other week".
    /// </summary>
    /// <remarks>Discord field: <c>interval</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required int Interval { get; set; }

    /// <summary>
    ///     Set of specific days within a week for the event to recur on.
    /// </summary>
    /// <remarks>Discord field: <c>by_weekday</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required List<RecurrenceWeekday>? ByWeekday { get; set; }

    /// <summary>
    ///     List of specific days within a specific week (1-5) to recur on.
    /// </summary>
    /// <remarks>Discord field: <c>by_n_weekday</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required List<RecurrenceRuleWeekday>? ByNWeekday { get; set; }

    /// <summary>
    ///     Set of specific months to recur on.
    /// </summary>
    /// <remarks>Discord field: <c>by_month</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required List<RecurrenceMonth>? ByMonth { get; set; }

    /// <summary>
    ///     Set of specific dates within a month to recur on.
    /// </summary>
    /// <remarks>Discord field: <c>by_month_day</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required List<int>? ByMonthDay { get; set; }

    /// <summary>
    ///     Set of days within a year to recur on (1-364).
    /// </summary>
    /// <remarks>Discord field: <c>by_year_day</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required List<int>? ByYearDay { get; set; }

    /// <summary>
    ///     The total amount of times that the event is allowed to recur before stopping.
    /// </summary>
    /// <remarks>Discord field: <c>count</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required int? Count { get; set; }
}