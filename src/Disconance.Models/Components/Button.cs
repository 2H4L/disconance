using Disconance.Models.Emojis;

namespace Disconance.Models.Components;

/// <summary>
///     Button data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
public class Button : Component
{
    /// <summary>
    ///     <c>2</c> for a button.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public override ComponentType Type => ComponentType.Button;

    /// <summary>
    ///     A button style.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>style</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public required ButtonStyle Style { get; set; }

    /// <summary>
    ///     Text that appears on the button; max 80 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>label</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public Optional<string> Label { get; set; }

    /// <summary>
    ///     <c>name</c> , <c>id</c> , and <c>animated</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>emoji</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public Optional<PartialEmoji> Emoji { get; set; }

    /// <summary>
    ///     Developer-defined identifier for the button; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public Optional<string> CustomId { get; set; }

    /// <summary>
    ///     Identifier for a purchasable SKU, only available when using premium-style buttons.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object" />
    public Optional<Snowflake> SkuId { get; set; }

    /// <summary>
    ///     URL for link-style buttons; max 512 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public Optional<string> Url { get; set; }

    /// <summary>
    ///     Whether the button is disabled (defaults to <c>false</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>disabled</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#button-button-structure" />
    public Optional<bool> Disabled { get; set; }
}