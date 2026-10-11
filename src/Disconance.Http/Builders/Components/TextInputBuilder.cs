using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes TextInput values. Discord limits are documented on the model.
/// </summary>
public sealed class TextInputBuilder : ModelBuilder<TextInput, TextInputBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Style; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithStyle(TextInputStyle value)
    {
        return Set("Style", value);
    }

    /// <summary>
    ///     Sets MinLength; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithMinLength(int value)
    {
        return Set("MinLength", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinLength from the composition.
    /// </summary>
    public TextInputBuilder OmitMinLength()
    {
        return Set("MinLength", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxLength; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithMaxLength(int value)
    {
        return Set("MaxLength", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxLength from the composition.
    /// </summary>
    public TextInputBuilder OmitMaxLength()
    {
        return Set("MaxLength", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public TextInputBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Value; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithValue(string value)
    {
        return Set("Value", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Value from the composition.
    /// </summary>
    public TextInputBuilder OmitValue()
    {
        return Set("Value", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public TextInputBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public TextInputBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public TextInputBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}