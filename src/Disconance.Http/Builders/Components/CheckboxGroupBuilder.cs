using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes CheckboxGroup values. Discord limits are documented on the model.
/// </summary>
public sealed class CheckboxGroupBuilder : ModelBuilder<CheckboxGroup, CheckboxGroupBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Options; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithOptions(List<CheckboxGroupOption> value)
    {
        return Set("Options", value);
    }

    /// <summary>
    ///     Appends one Option.
    /// </summary>
    public CheckboxGroupBuilder AddOption(CheckboxGroupOption value)
    {
        return Add("Options", value);
    }

    /// <summary>
    ///     Composes and appends CheckboxGroupOption.
    /// </summary>
    public CheckboxGroupBuilder AddOption(Action<CheckboxGroupOptionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupOptionBuilder();
        configure(builder);
        return AddOption(builder.Build());
    }

    /// <summary>
    ///     Sets MinValues; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithMinValues(int value)
    {
        return Set("MinValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinValues from the composition.
    /// </summary>
    public CheckboxGroupBuilder OmitMinValues()
    {
        return Set("MinValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxValues; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithMaxValues(int value)
    {
        return Set("MaxValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxValues from the composition.
    /// </summary>
    public CheckboxGroupBuilder OmitMaxValues()
    {
        return Set("MaxValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public CheckboxGroupBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public CheckboxGroupBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}