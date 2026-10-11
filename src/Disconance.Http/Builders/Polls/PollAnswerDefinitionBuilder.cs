using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Polls;

/// <summary>
///     Fluently composes PollAnswerDefinition values. Discord limits are documented on the model.
/// </summary>
public sealed class PollAnswerDefinitionBuilder : ModelBuilder<PollAnswerDefinition, PollAnswerDefinitionBuilder>
{
    /// <summary>
    ///     Sets PollMedia; explicit values, including defaults, remain present.
    /// </summary>
    public PollAnswerDefinitionBuilder WithPollMedia(PollMedia value)
    {
        return Set("PollMedia", value);
    }

    /// <summary>
    ///     Composes PollMedia with a nested builder.
    /// </summary>
    public PollAnswerDefinitionBuilder WithPollMedia(Action<PollMediaBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollMediaBuilder();
        configure(builder);
        return WithPollMedia(builder.Build());
    }
}