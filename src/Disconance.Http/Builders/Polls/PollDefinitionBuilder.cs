using Disconance.Models;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Polls;

/// <summary>
///     Fluently composes PollDefinition values. Discord limits are documented on the model.
/// </summary>
public sealed class PollDefinitionBuilder : ModelBuilder<PollDefinition, PollDefinitionBuilder>
{
    /// <summary>
    ///     Sets Question; explicit values, including defaults, remain present.
    /// </summary>
    public PollDefinitionBuilder WithQuestion(PollMedia value)
    {
        return Set("Question", value);
    }

    /// <summary>
    ///     Composes Question with a nested builder.
    /// </summary>
    public PollDefinitionBuilder WithQuestion(Action<PollMediaBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollMediaBuilder();
        configure(builder);
        return WithQuestion(builder.Build());
    }

    /// <summary>
    ///     Sets Answers; explicit values, including defaults, remain present.
    /// </summary>
    public PollDefinitionBuilder WithAnswers(List<PollAnswerDefinition> value)
    {
        return Set("Answers", value);
    }

    /// <summary>
    ///     Appends one Answer.
    /// </summary>
    public PollDefinitionBuilder AddAnswer(PollAnswerDefinition value)
    {
        return Add("Answers", value);
    }

    /// <summary>
    ///     Composes and appends PollAnswerDefinition.
    /// </summary>
    public PollDefinitionBuilder AddAnswer(Action<PollAnswerDefinitionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollAnswerDefinitionBuilder();
        configure(builder);
        return AddAnswer(builder.Build());
    }

    /// <summary>
    ///     Sets Duration; explicit values, including defaults, remain present.
    /// </summary>
    public PollDefinitionBuilder WithDuration(int value)
    {
        return Set("Duration", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Duration from the composition.
    /// </summary>
    public PollDefinitionBuilder OmitDuration()
    {
        return Set("Duration", default(Optional<int>));
    }

    /// <summary>
    ///     Sets AllowMultiselect; explicit values, including defaults, remain present.
    /// </summary>
    public PollDefinitionBuilder WithAllowMultiselect(bool value)
    {
        return Set("AllowMultiselect", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits AllowMultiselect from the composition.
    /// </summary>
    public PollDefinitionBuilder OmitAllowMultiselect()
    {
        return Set("AllowMultiselect", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets LayoutType; explicit values, including defaults, remain present.
    /// </summary>
    public PollDefinitionBuilder WithLayoutType(PollLayoutType value)
    {
        return Set("LayoutType", new Optional<PollLayoutType>(value));
    }

    /// <summary>
    ///     Omits LayoutType from the composition.
    /// </summary>
    public PollDefinitionBuilder OmitLayoutType()
    {
        return Set("LayoutType", default(Optional<PollLayoutType>));
    }
}