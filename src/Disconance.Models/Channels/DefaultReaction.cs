namespace Disconance.Models.Channels;

/// <summary>
///     Default Reaction data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#default-reaction-object" />
public class DefaultReaction
{
    /// <summary>
    ///     The id of a guild's custom emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#default-reaction-object" />
    public required Snowflake? EmojiId { get; set; }

    /// <summary>
    ///     The unicode character of the emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#default-reaction-object" />
    public required string? EmojiName { get; set; }
}