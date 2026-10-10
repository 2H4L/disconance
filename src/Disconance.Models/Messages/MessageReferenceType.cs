namespace Disconance.Models.Messages;

/// <summary>
///     Message Reference Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-types" />
public enum MessageReferenceType
{
    /// <summary>
    ///     A standard reference used by replies.
    /// </summary>
    Default = 0,

    /// <summary>
    ///     Reference used to point to a message at a point in time.
    /// </summary>
    Forward = 1
}