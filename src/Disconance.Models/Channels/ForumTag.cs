namespace Disconance.Models.Channels;

/// <summary>
///     Forum Tag data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
public class ForumTag
{
    /// <summary>
    ///     The id of the tag.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The name of the tag (0-20 characters).
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Whether this tag can only be added to or removed from threads by a member with the <c>MANAGE_THREADS</c>
    ///     permission.
    /// </summary>
    /// <remarks>Discord field: <c>moderated</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
    public required bool Moderated { get; set; }

    /// <summary>
    ///     The id of a guild's custom emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
    public required Snowflake? EmojiId { get; set; }

    /// <summary>
    ///     The unicode character of the emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#forum-tag-object-forum-tag-structure" />
    public required string? EmojiName { get; set; }
}