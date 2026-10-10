namespace Disconance.Models.Activities;

/// <summary>
///     Known Discord status types. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#update-presence-status-types" />
public static class ActivityStatus
{
    /// <summary>
    ///     Online
    /// </summary>
    public const string Online = "online";

    /// <summary>
    ///     Do Not Disturb
    /// </summary>
    public const string Dnd = "dnd";

    /// <summary>
    ///     AFK
    /// </summary>
    public const string Idle = "idle";

    /// <summary>
    ///     Invisible and shown as offline.
    /// </summary>
    public const string Invisible = "invisible";

    /// <summary>
    ///     Offline
    /// </summary>
    public const string Offline = "offline";
}