namespace Disconance.Models.Messages;

/// <summary>
///     Message Activity Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-activity-types" />
public enum MessageActivityType
{
    /// <summary>
    ///     JOIN
    /// </summary>
    Join = 1,

    /// <summary>
    ///     SPECTATE
    /// </summary>
    Spectate = 2,

    /// <summary>
    ///     LISTEN
    /// </summary>
    Listen = 3,

    /// <summary>
    ///     JOIN_REQUEST
    /// </summary>
    JoinRequest = 5,

    /// <summary>
    ///     STREAM_REQUEST
    /// </summary>
    StreamRequest = 6
}