using Disconance.Models.Channels;

namespace Disconance.Models.Messages;

/// <summary>
///     Channel Mention data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/message#channel-mention-object-channel-mention-structure" />
public class ChannelMention
{
    /// <summary>
    ///     Id of the channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#channel-mention-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Id of the guild containing the channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#channel-mention-object" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     The type of channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#channel-mention-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-types" />
    public required ChannelType Type { get; set; }

    /// <summary>
    ///     The name of the channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#channel-mention-object" />
    public required string Name { get; set; }
}