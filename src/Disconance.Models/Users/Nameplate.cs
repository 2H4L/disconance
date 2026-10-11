namespace Disconance.Models.Users;

/// <summary>
///     Nameplate data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#nameplate-nameplate-structure" />
public class Nameplate
{
    /// <summary>
    ///     Id of the nameplate SKU.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#nameplate-nameplate-structure" />
    public required Snowflake SkuId { get; set; }

    /// <summary>
    ///     Path to the nameplate asset.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>asset</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#nameplate-nameplate-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string Asset { get; set; }

    /// <summary>
    ///     The label of this nameplate. Currently unused.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>label</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#nameplate-nameplate-structure" />
    public required string Label { get; set; }

    /// <summary>
    ///     Background color of the nameplate, one of: <c>crimson</c> , <c>berry</c> , <c>sky</c> , <c>teal</c> ,
    ///     <c>forest</c> , <c>bubble_gum</c> , <c>violet</c> , <c>cobalt</c> , <c>clover</c> , <c>lemon</c> ,
    ///     <c>white</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>palette</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#nameplate-nameplate-structure" />
    public required string Palette { get; set; }
}