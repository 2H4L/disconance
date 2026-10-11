using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes CheckboxGroupOption values. Discord limits are documented on the model.
/// </summary>
public sealed class CheckboxGroupOptionBuilder : ModelBuilder<CheckboxGroupOption, CheckboxGroupOptionBuilder>
{
    /// <summary>
    ///     Sets Value; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupOptionBuilder WithValue(string value)
    {
        return Set("Value", value);
    }

    /// <summary>
    ///     Sets Label; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupOptionBuilder WithLabel(string value)
    {
        return Set("Label", value);
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupOptionBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public CheckboxGroupOptionBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Default; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxGroupOptionBuilder WithDefault(bool value)
    {
        return Set("Default", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Default from the composition.
    /// </summary>
    public CheckboxGroupOptionBuilder OmitDefault()
    {
        return Set("Default", default(Optional<bool>));
    }
}