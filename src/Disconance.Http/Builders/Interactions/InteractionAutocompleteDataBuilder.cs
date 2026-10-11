using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently composes InteractionAutocompleteData values. Discord limits are documented on the model.
/// </summary>
public sealed class
    InteractionAutocompleteDataBuilder : ModelBuilder<InteractionAutocompleteData, InteractionAutocompleteDataBuilder>
{
    /// <summary>
    ///     Sets Choices; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionAutocompleteDataBuilder WithChoices(List<ApplicationCommandOptionChoice> value)
    {
        return Set("Choices", value);
    }

    /// <summary>
    ///     Appends one Choice.
    /// </summary>
    public InteractionAutocompleteDataBuilder AddChoice(ApplicationCommandOptionChoice value)
    {
        return Add("Choices", value);
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOptionChoice.
    /// </summary>
    public InteractionAutocompleteDataBuilder AddChoice(Action<ApplicationCommandOptionChoiceBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ApplicationCommandOptionChoiceBuilder();
        configure(builder);
        return AddChoice(builder.Build());
    }
}