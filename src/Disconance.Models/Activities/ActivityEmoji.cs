namespace Disconance.Models.Activities;

/// <summary>
///     Activity Emoji data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-emoji" />
public class ActivityEmoji
{
    /// <summary>
    ///     Name of the emoji.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-emoji" />
    public required string Name { get; set; }

    /// <summary>
    ///     ID of the emoji.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-emoji" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     Whether the emoji is animated.
    /// </summary>
    /// <remarks>Discord field: <c>animated</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-emoji" />
    public Optional<bool> Animated { get; set; }
}