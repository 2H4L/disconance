namespace Disconance.Models.Activities;

/// <summary>
///     Status Display Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-status-display-types" />
public enum ActivityStatusDisplayType
{
    /// <summary>
    ///     Name
    /// </summary>
    Name = 0,

    /// <summary>
    ///     State
    /// </summary>
    State = 1,

    /// <summary>
    ///     Details
    /// </summary>
    Details = 2
}