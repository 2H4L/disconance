using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes RadioGroup values. Discord limits are documented on the model.
/// </summary>
public sealed class RadioGroupBuilder : ModelBuilder<RadioGroup, RadioGroupBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public RadioGroupBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Options; explicit values, including defaults, remain present.
    /// </summary>
    public RadioGroupBuilder WithOptions(List<RadioGroupOption> value)
    {
        return Set("Options", value);
    }

    /// <summary>
    ///     Appends one Option.
    /// </summary>
    public RadioGroupBuilder AddOption(RadioGroupOption value)
    {
        return Add("Options", value);
    }

    /// <summary>
    ///     Composes and appends RadioGroupOption.
    /// </summary>
    public RadioGroupBuilder AddOption(Action<RadioGroupOptionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupOptionBuilder();
        configure(builder);
        return AddOption(builder.Build());
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public RadioGroupBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public RadioGroupBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public RadioGroupBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public RadioGroupBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}