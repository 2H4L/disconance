namespace Disconance.Models.Guilds;

/// <summary>
///     Welcome Screen Channel data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#welcome-screen-object" />
public class WelcomeScreenChannel
{
    /// <summary>
    ///     The channel's id.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#welcome-screen-object" />
    public required Snowflake ChannelId { get; set; }

    /// <summary>
    ///     The description shown for the channel.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#welcome-screen-object" />
    public required string Description { get; set; }

    /// <summary>
    ///     The emoji id, if the emoji is custom.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#welcome-screen-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required Snowflake? EmojiId { get; set; }

    /// <summary>
    ///     The emoji name if custom, the unicode character if standard, or <c>null</c> if no emoji is set.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#welcome-screen-object" />
    public required string? EmojiName { get; set; }
}