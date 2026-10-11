namespace Disconance.Models.Messages;

/// <summary>
///     Message Pin data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/message#message-pin-object-message-pin-object-structure" />
public class MessagePin
{
    /// <summary>
    ///     The time the message was pinned.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>pinned_at</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-pin-object" />
    public required DateTimeOffset PinnedAt { get; set; }

    /// <summary>
    ///     The pinned message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>message</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-pin-object" />
    public required Message Message { get; set; }
}