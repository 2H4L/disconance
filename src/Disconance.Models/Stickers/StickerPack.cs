namespace Disconance.Models.Stickers;

/// <summary>
///     Sticker Pack data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
public class StickerPack
{
    /// <summary>
    ///     Id of the sticker pack.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The stickers in the pack.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>stickers</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public required List<Sticker> Stickers { get; set; }

    /// <summary>
    ///     Name of the sticker pack.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Id of the pack's SKU.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public required Snowflake SkuId { get; set; }

    /// <summary>
    ///     Id of a sticker in the pack which is shown as the pack's icon.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>cover_sticker_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public Optional<Snowflake> CoverStickerId { get; set; }

    /// <summary>
    ///     Description of the sticker pack.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    public required string Description { get; set; }

    /// <summary>
    ///     Id of the sticker pack's banner image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>banner_asset_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/sticker#sticker-pack-object-sticker-pack-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<Snowflake> BannerAssetId { get; set; }
}