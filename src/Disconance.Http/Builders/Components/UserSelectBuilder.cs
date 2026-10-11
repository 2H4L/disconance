using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes UserSelect values. Discord limits are documented on the model.
/// </summary>
public sealed class UserSelectBuilder : ModelBuilder<UserSelect, UserSelectBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public UserSelectBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets DefaultValues; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithDefaultValues(List<SelectDefaultValue> value)
    {
        return Set("DefaultValues", new Optional<List<SelectDefaultValue>>(value));
    }

    /// <summary>
    ///     Omits DefaultValues from the composition.
    /// </summary>
    public UserSelectBuilder OmitDefaultValues()
    {
        return Set("DefaultValues", default(Optional<List<SelectDefaultValue>>));
    }

    /// <summary>
    ///     Appends one DefaultValue.
    /// </summary>
    public UserSelectBuilder AddDefaultValue(SelectDefaultValue value)
    {
        return Add("DefaultValues", value);
    }

    /// <summary>
    ///     Composes and appends SelectDefaultValue.
    /// </summary>
    public UserSelectBuilder AddDefaultValue(Action<SelectDefaultValueBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SelectDefaultValueBuilder();
        configure(builder);
        return AddDefaultValue(builder.Build());
    }

    /// <summary>
    ///     Sets MinValues; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithMinValues(int value)
    {
        return Set("MinValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinValues from the composition.
    /// </summary>
    public UserSelectBuilder OmitMinValues()
    {
        return Set("MinValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxValues; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithMaxValues(int value)
    {
        return Set("MaxValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxValues from the composition.
    /// </summary>
    public UserSelectBuilder OmitMaxValues()
    {
        return Set("MaxValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public UserSelectBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Disabled; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithDisabled(bool value)
    {
        return Set("Disabled", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Disabled from the composition.
    /// </summary>
    public UserSelectBuilder OmitDisabled()
    {
        return Set("Disabled", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public UserSelectBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public UserSelectBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}