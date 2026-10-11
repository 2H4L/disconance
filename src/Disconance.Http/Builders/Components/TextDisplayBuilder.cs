using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes TextDisplay values. Discord limits are documented on the model.
/// </summary>
public sealed class TextDisplayBuilder : ModelBuilder<TextDisplay, TextDisplayBuilder>
{
    /// <summary>
    ///     Sets Content; explicit values, including defaults, remain present.
    /// </summary>
    public TextDisplayBuilder WithContent(string value)
    {
        return Set("Content", value);
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public TextDisplayBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public TextDisplayBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}