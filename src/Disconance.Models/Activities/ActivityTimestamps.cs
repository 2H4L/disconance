namespace Disconance.Models.Activities;

/// <summary>
///     Activity Timestamps data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-timestamps" />
public class ActivityTimestamps
{
    /// <summary>
    ///     Unix time (in milliseconds) of when the activity started.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>start</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-timestamps" />
    public Optional<long> Start { get; set; }

    /// <summary>
    ///     Unix time (in milliseconds) of when the activity ends.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>end</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-timestamps" />
    public Optional<long> End { get; set; }
}