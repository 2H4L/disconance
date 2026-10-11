using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Emojis;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Button values. Discord limits are documented on the model.
/// </summary>
public sealed class ButtonBuilder : ModelBuilder<Button, ButtonBuilder>
{
    /// <summary>
    ///     Sets Style; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithStyle(ButtonStyle value)
    {
        return Set("Style", value);
    }

    /// <summary>
    ///     Sets Label; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithLabel(string value)
    {
        return Set("Label", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Label from the composition.
    /// </summary>
    public ButtonBuilder OmitLabel()
    {
        return Set("Label", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Emoji; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithEmoji(PartialEmoji value)
    {
        return Set("Emoji", new Optional<PartialEmoji>(value));
    }

    /// <summary>
    ///     Omits Emoji from the composition.
    /// </summary>
    public ButtonBuilder OmitEmoji()
    {
        return Set("Emoji", default(Optional<PartialEmoji>));
    }

    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithCustomId(string value)
    {
        return Set("CustomId", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits CustomId from the composition.
    /// </summary>
    public ButtonBuilder OmitCustomId()
    {
        return Set("CustomId", default(Optional<string>));
    }

    /// <summary>
    ///     Sets SkuId; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithSkuId(Snowflake value)
    {
        return Set("SkuId", new Optional<Snowflake>(value));
    }

    /// <summary>
    ///     Omits SkuId from the composition.
    /// </summary>
    public ButtonBuilder OmitSkuId()
    {
        return Set("SkuId", default(Optional<Snowflake>));
    }

    /// <summary>
    ///     Sets Url; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithUrl(string value)
    {
        return Set("Url", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Url from the composition.
    /// </summary>
    public ButtonBuilder OmitUrl()
    {
        return Set("Url", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Disabled; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithDisabled(bool value)
    {
        return Set("Disabled", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Disabled from the composition.
    /// </summary>
    public ButtonBuilder OmitDisabled()
    {
        return Set("Disabled", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public ButtonBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public ButtonBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}