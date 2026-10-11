using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Emojis;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes SelectOption values. Discord limits are documented on the model.
/// </summary>
public sealed class SelectOptionBuilder : ModelBuilder<SelectOption, SelectOptionBuilder>
{
    /// <summary>
    ///     Sets Label; explicit values, including defaults, remain present.
    /// </summary>
    public SelectOptionBuilder WithLabel(string value)
    {
        return Set("Label", value);
    }

    /// <summary>
    ///     Sets Value; explicit values, including defaults, remain present.
    /// </summary>
    public SelectOptionBuilder WithValue(string value)
    {
        return Set("Value", value);
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public SelectOptionBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public SelectOptionBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Emoji; explicit values, including defaults, remain present.
    /// </summary>
    public SelectOptionBuilder WithEmoji(PartialEmoji value)
    {
        return Set("Emoji", new Optional<PartialEmoji>(value));
    }

    /// <summary>
    ///     Omits Emoji from the composition.
    /// </summary>
    public SelectOptionBuilder OmitEmoji()
    {
        return Set("Emoji", default(Optional<PartialEmoji>));
    }

    /// <summary>
    ///     Sets Default; explicit values, including defaults, remain present.
    /// </summary>
    public SelectOptionBuilder WithDefault(bool value)
    {
        return Set("Default", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Default from the composition.
    /// </summary>
    public SelectOptionBuilder OmitDefault()
    {
        return Set("Default", default(Optional<bool>));
    }
}