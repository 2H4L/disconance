using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes EmbedField values. Discord limits are documented on the model.
/// </summary>
public sealed class EmbedFieldBuilder : ModelBuilder<EmbedField, EmbedFieldBuilder>
{
    /// <summary>
    ///     Sets Name; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFieldBuilder WithName(string value)
    {
        return Set("Name", value);
    }

    /// <summary>
    ///     Sets Value; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFieldBuilder WithValue(string value)
    {
        return Set("Value", value);
    }

    /// <summary>
    ///     Sets Inline; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFieldBuilder WithInline(bool value)
    {
        return Set("Inline", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Inline from the composition.
    /// </summary>
    public EmbedFieldBuilder OmitInline()
    {
        return Set("Inline", default(Optional<bool>));
    }
}