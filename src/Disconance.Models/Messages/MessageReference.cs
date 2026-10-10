namespace Disconance.Models.Messages;

/// <summary>
///     Message Reference data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
public class MessageReference
{
    /// <summary>
    ///     Type of reference.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
    public Optional<MessageReferenceType> Type { get; set; }

    /// <summary>
    ///     Id of the originating message.
    /// </summary>
    /// <remarks>Discord field: <c>message_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
    public Optional<Snowflake> MessageId { get; set; }

    /// <summary>
    ///     Id of the originating message's channel.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
    public Optional<Snowflake> ChannelId { get; set; }

    /// <summary>
    ///     Id of the originating message's guild.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     When sending, whether to error if the referenced message doesn't exist instead of sending as a normal
    ///     (non-reply) message, default true.
    /// </summary>
    /// <remarks>Discord field: <c>fail_if_not_exists</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-reference-structure" />
    public Optional<bool> FailIfNotExists { get; set; }
}