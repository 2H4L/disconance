namespace Disconance.Models.Messages;

/// <summary>
///     Message Snapshot data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-snapshot-structure" />
public class MessageSnapshot
{
    /// <summary>
    ///     Minimal subset of fields in the forwarded message.
    /// </summary>
    /// <remarks>Discord field: <c>message</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-snapshot-structure" />
    public required PartialMessage Message { get; set; }
}