namespace Disconance.Models.Skus;

/// <summary>
///     SKU data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
public class Sku
{
    /// <summary>
    ///     ID of SKU.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of SKU.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    public required SkuType Type { get; set; }

    /// <summary>
    ///     ID of the parent application.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     Customer-facing name of your premium offering.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     System-generated URL slug based on the SKU's name.
    /// </summary>
    /// <remarks>Discord field: <c>slug</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    public required string Slug { get; set; }

    /// <summary>
    ///     SKU flags combined as a bitfield.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public required SkuFlags Flags { get; set; }
}