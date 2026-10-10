using Disconance.Models.Users;

namespace Disconance.Models.Stickers;

/// <summary>
///     Sticker data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
public class Sticker
{
    /// <summary>
    ///     Id of the sticker.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     For standard stickers, id of the pack the sticker is from.
    /// </summary>
    /// <remarks>Discord field: <c>pack_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public Optional<Snowflake> PackId { get; set; }

    /// <summary>
    ///     Name of the sticker.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Description of the sticker.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public required string? Description { get; set; }

    /// <summary>
    ///     Autocomplete/suggestion tags for the sticker (max 200 characters).
    /// </summary>
    /// <remarks>Discord field: <c>tags</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public required string Tags { get; set; }

    /// <summary>
    ///     Type of sticker.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public required StickerType Type { get; set; }

    /// <summary>
    ///     Type of sticker format.
    /// </summary>
    /// <remarks>Discord field: <c>format_type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public required StickerFormatType FormatType { get; set; }

    /// <summary>
    ///     Whether this guild sticker can be used, may be false due to loss of Server Boosts.
    /// </summary>
    /// <remarks>Discord field: <c>available</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public Optional<bool> Available { get; set; }

    /// <summary>
    ///     Id of the guild that owns this sticker.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     The user that uploaded the guild sticker.
    /// </summary>
    /// <remarks>Discord field: <c>user</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     The standard sticker's sort order within its pack.
    /// </summary>
    /// <remarks>Discord field: <c>sort_value</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-structure" />
    public Optional<int> SortValue { get; set; }
}