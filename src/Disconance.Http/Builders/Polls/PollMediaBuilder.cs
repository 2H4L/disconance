using Disconance.Models;
using Disconance.Models.Emojis;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Polls;

/// <summary>
///     Fluently composes PollMedia values. Discord limits are documented on the model.
/// </summary>
public sealed class PollMediaBuilder : ModelBuilder<PollMedia, PollMediaBuilder>
{
    /// <summary>
    ///     Sets Text; explicit values, including defaults, remain present.
    /// </summary>
    public PollMediaBuilder WithText(string value)
    {
        return Set("Text", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Text from the composition.
    /// </summary>
    public PollMediaBuilder OmitText()
    {
        return Set("Text", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Emoji; explicit values, including defaults, remain present.
    /// </summary>
    public PollMediaBuilder WithEmoji(PartialEmoji value)
    {
        return Set("Emoji", new Optional<PartialEmoji>(value));
    }

    /// <summary>
    ///     Omits Emoji from the composition.
    /// </summary>
    public PollMediaBuilder OmitEmoji()
    {
        return Set("Emoji", default(Optional<PartialEmoji>));
    }
}