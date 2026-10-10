namespace Disconance.Models.Activities;

/// <summary>
///     Activity Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-types" />
public enum ActivityType
{
    /// <summary>
    ///     Playing
    /// </summary>
    Playing = 0,

    /// <summary>
    ///     Streaming
    /// </summary>
    Streaming = 1,

    /// <summary>
    ///     Listening
    /// </summary>
    Listening = 2,

    /// <summary>
    ///     Watching
    /// </summary>
    Watching = 3,

    /// <summary>
    ///     Custom
    /// </summary>
    Custom = 4,

    /// <summary>
    ///     Competing
    /// </summary>
    Competing = 5
}