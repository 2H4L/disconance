using Disconance.Models;
using Disconance.Models.Channels;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Interactions.Commands;

/// <summary>
///     Fluently composes ApplicationCommandOption values. Discord limits are documented on the model.
/// </summary>
public sealed class
    ApplicationCommandOptionBuilder : ModelBuilder<ApplicationCommandOption, ApplicationCommandOptionBuilder>
{
    /// <summary>
    ///     Sets Type; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithType(ApplicationCommandOptionType value)
    {
        return Set("Type", value);
    }

    /// <summary>
    ///     Sets Name; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithName(string value)
    {
        return Set("Name", value);
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        return Set("NameLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits NameLocalizations from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitNameLocalizations()
    {
        return Set("NameLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithDescription(string value)
    {
        return Set("Description", value);
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        return Set("DescriptionLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits DescriptionLocalizations from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitDescriptionLocalizations()
    {
        return Set("DescriptionLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Choices; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithChoices(List<ApplicationCommandOptionChoice> value)
    {
        return Set("Choices", new Optional<List<ApplicationCommandOptionChoice>>(value));
    }

    /// <summary>
    ///     Omits Choices from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitChoices()
    {
        return Set("Choices", default(Optional<List<ApplicationCommandOptionChoice>>));
    }

    /// <summary>
    ///     Appends one Choice.
    /// </summary>
    public ApplicationCommandOptionBuilder AddChoice(ApplicationCommandOptionChoice value)
    {
        return Add("Choices", value);
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOptionChoice.
    /// </summary>
    public ApplicationCommandOptionBuilder AddChoice(Action<ApplicationCommandOptionChoiceBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ApplicationCommandOptionChoiceBuilder();
        configure(builder);
        return AddChoice(builder.Build());
    }

    /// <summary>
    ///     Sets Options; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        return Set("Options", new Optional<List<ApplicationCommandOption>>(value));
    }

    /// <summary>
    ///     Omits Options from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitOptions()
    {
        return Set("Options", default(Optional<List<ApplicationCommandOption>>));
    }

    /// <summary>
    ///     Appends one Option.
    /// </summary>
    public ApplicationCommandOptionBuilder AddOption(ApplicationCommandOption value)
    {
        return Add("Options", value);
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public ApplicationCommandOptionBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ApplicationCommandOptionBuilder();
        configure(builder);
        return AddOption(builder.Build());
    }

    /// <summary>
    ///     Sets ChannelTypes; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithChannelTypes(List<ChannelType> value)
    {
        return Set("ChannelTypes", new Optional<List<ChannelType>>(value));
    }

    /// <summary>
    ///     Omits ChannelTypes from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitChannelTypes()
    {
        return Set("ChannelTypes", default(Optional<List<ChannelType>>));
    }

    /// <summary>
    ///     Appends one ChannelType.
    /// </summary>
    public ApplicationCommandOptionBuilder AddChannelType(ChannelType value)
    {
        return Add("ChannelTypes", value);
    }

    /// <summary>
    ///     Sets MinValue; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithMinValue(double value)
    {
        return Set("MinValue", new Optional<double>(value));
    }

    /// <summary>
    ///     Omits MinValue from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitMinValue()
    {
        return Set("MinValue", default(Optional<double>));
    }

    /// <summary>
    ///     Sets MaxValue; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithMaxValue(double value)
    {
        return Set("MaxValue", new Optional<double>(value));
    }

    /// <summary>
    ///     Omits MaxValue from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitMaxValue()
    {
        return Set("MaxValue", default(Optional<double>));
    }

    /// <summary>
    ///     Sets MinLength; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithMinLength(int value)
    {
        return Set("MinLength", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinLength from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitMinLength()
    {
        return Set("MinLength", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxLength; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithMaxLength(int value)
    {
        return Set("MaxLength", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxLength from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitMaxLength()
    {
        return Set("MaxLength", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Autocomplete; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithAutocomplete(bool value)
    {
        return Set("Autocomplete", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Autocomplete from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitAutocomplete()
    {
        return Set("Autocomplete", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets FileTypes; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionBuilder WithFileTypes(List<string> value)
    {
        return Set("FileTypes", new Optional<List<string>>(value));
    }

    /// <summary>
    ///     Omits FileTypes from the composition.
    /// </summary>
    public ApplicationCommandOptionBuilder OmitFileTypes()
    {
        return Set("FileTypes", default(Optional<List<string>>));
    }

    /// <summary>
    ///     Appends one FileType.
    /// </summary>
    public ApplicationCommandOptionBuilder AddFileType(string value)
    {
        return Add("FileTypes", value);
    }
}