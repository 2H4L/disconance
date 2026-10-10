namespace Disconance.Models.Messages;

/// <summary>
///     Message Call data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-call-object" />
public class MessageCall
{
    /// <summary>
    ///     Array of user object ids that participated in the call.
    /// </summary>
    /// <remarks>Discord field: <c>participants</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-call-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object" />
    public required List<Snowflake> Participants { get; set; }

    /// <summary>
    ///     Time when call ended.
    /// </summary>
    /// <remarks>Discord field: <c>ended_timestamp</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-call-object" />
    public Optional<DateTimeOffset?> EndedTimestamp { get; set; }
}