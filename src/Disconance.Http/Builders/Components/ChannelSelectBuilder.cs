using Disconance.Models;
using Disconance.Models.Channels;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes ChannelSelect values. Discord limits are documented on the model.
/// </summary>
public sealed class ChannelSelectBuilder : ModelBuilder<ChannelSelect, ChannelSelectBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets ChannelTypes; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithChannelTypes(List<ChannelType> value)
    {
        return Set("ChannelTypes", new Optional<List<ChannelType>>(value));
    }

    /// <summary>
    ///     Omits ChannelTypes from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitChannelTypes()
    {
        return Set("ChannelTypes", default(Optional<List<ChannelType>>));
    }

    /// <summary>
    ///     Appends one ChannelType.
    /// </summary>
    public ChannelSelectBuilder AddChannelType(ChannelType value)
    {
        return Add("ChannelTypes", value);
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets DefaultValues; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithDefaultValues(List<SelectDefaultValue> value)
    {
        return Set("DefaultValues", new Optional<List<SelectDefaultValue>>(value));
    }

    /// <summary>
    ///     Omits DefaultValues from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitDefaultValues()
    {
        return Set("DefaultValues", default(Optional<List<SelectDefaultValue>>));
    }

    /// <summary>
    ///     Appends one DefaultValue.
    /// </summary>
    public ChannelSelectBuilder AddDefaultValue(SelectDefaultValue value)
    {
        return Add("DefaultValues", value);
    }

    /// <summary>
    ///     Composes and appends SelectDefaultValue.
    /// </summary>
    public ChannelSelectBuilder AddDefaultValue(Action<SelectDefaultValueBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SelectDefaultValueBuilder();
        configure(builder);
        return AddDefaultValue(builder.Build());
    }

    /// <summary>
    ///     Sets MinValues; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithMinValues(int value)
    {
        return Set("MinValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinValues from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitMinValues()
    {
        return Set("MinValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxValues; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithMaxValues(int value)
    {
        return Set("MaxValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxValues from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitMaxValues()
    {
        return Set("MaxValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Disabled; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithDisabled(bool value)
    {
        return Set("Disabled", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Disabled from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitDisabled()
    {
        return Set("Disabled", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public ChannelSelectBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public ChannelSelectBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}