using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes MentionableSelect values. Discord limits are documented on the model.
/// </summary>
public sealed class MentionableSelectBuilder : ModelBuilder<MentionableSelect, MentionableSelectBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets DefaultValues; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithDefaultValues(List<SelectDefaultValue> value)
    {
        return Set("DefaultValues", new Optional<List<SelectDefaultValue>>(value));
    }

    /// <summary>
    ///     Omits DefaultValues from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitDefaultValues()
    {
        return Set("DefaultValues", default(Optional<List<SelectDefaultValue>>));
    }

    /// <summary>
    ///     Appends one DefaultValue.
    /// </summary>
    public MentionableSelectBuilder AddDefaultValue(SelectDefaultValue value)
    {
        return Add("DefaultValues", value);
    }

    /// <summary>
    ///     Composes and appends SelectDefaultValue.
    /// </summary>
    public MentionableSelectBuilder AddDefaultValue(Action<SelectDefaultValueBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SelectDefaultValueBuilder();
        configure(builder);
        return AddDefaultValue(builder.Build());
    }

    /// <summary>
    ///     Sets MinValues; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithMinValues(int value)
    {
        return Set("MinValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinValues from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitMinValues()
    {
        return Set("MinValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxValues; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithMaxValues(int value)
    {
        return Set("MaxValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxValues from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitMaxValues()
    {
        return Set("MaxValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Disabled; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithDisabled(bool value)
    {
        return Set("Disabled", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Disabled from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitDisabled()
    {
        return Set("Disabled", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public MentionableSelectBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public MentionableSelectBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}