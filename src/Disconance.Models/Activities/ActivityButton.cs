namespace Disconance.Models.Activities;

/// <summary>
///     Activity Buttons data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-buttons" />
public class ActivityButton
{
    /// <summary>
    ///     Text shown on the button (1-32 characters).
    /// </summary>
    /// <remarks>Discord field: <c>label</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-buttons" />
    public required string Label { get; set; }

    /// <summary>
    ///     URL opened when clicking the button (1-512 characters).
    /// </summary>
    /// <remarks>Discord field: <c>url</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-buttons" />
    public required string Url { get; set; }
}