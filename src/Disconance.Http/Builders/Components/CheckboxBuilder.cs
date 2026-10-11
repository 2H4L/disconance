using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Checkbox values. Discord limits are documented on the model.
/// </summary>
public sealed class CheckboxBuilder : ModelBuilder<Checkbox, CheckboxBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Default; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxBuilder WithDefault(bool value)
    {
        return Set("Default", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Default from the composition.
    /// </summary>
    public CheckboxBuilder OmitDefault()
    {
        return Set("Default", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public CheckboxBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public CheckboxBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}