using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Interactions.Commands;

/// <summary>
///     Fluently composes ApplicationCommandOptionChoice values. Discord limits are documented on the model.
/// </summary>
public sealed class
    ApplicationCommandOptionChoiceBuilder : ModelBuilder<ApplicationCommandOptionChoice,
    ApplicationCommandOptionChoiceBuilder>
{
    /// <summary>
    ///     Sets a string choice value.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithValue(string value)
    {
        return WithValue(new StringCommandValue(value));
    }

    /// <summary>
    ///     Sets a long choice value.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithValue(long value)
    {
        return WithValue(new IntegerCommandValue(value));
    }

    /// <summary>
    ///     Sets a double choice value.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithValue(double value)
    {
        return WithValue(new NumberCommandValue(value));
    }

    /// <summary>
    ///     Sets Name; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithName(string value)
    {
        return Set("Name", value);
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        return Set("NameLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits NameLocalizations from the composition.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder OmitNameLocalizations()
    {
        return Set("NameLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sets Value; explicit values, including defaults, remain present.
    /// </summary>
    public ApplicationCommandOptionChoiceBuilder WithValue(CommandChoiceValue value)
    {
        return Set("Value", value);
    }
}