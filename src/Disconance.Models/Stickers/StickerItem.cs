namespace Disconance.Models.Stickers;

/// <summary>
///     Sticker Item data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-item-object-sticker-item-structure" />
public class StickerItem
{
    /// <summary>
    ///     Id of the sticker.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-item-object-sticker-item-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Name of the sticker.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-item-object-sticker-item-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Type of sticker format.
    /// </summary>
    /// <remarks>Discord field: <c>format_type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-item-object-sticker-item-structure" />
    public required StickerFormatType FormatType { get; set; }
}