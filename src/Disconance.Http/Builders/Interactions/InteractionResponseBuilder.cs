using Disconance.Models;
using Disconance.Models.Interactions;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently composes InteractionResponse values. Discord limits are documented on the model.
/// </summary>
public sealed class InteractionResponseBuilder : ModelBuilder<InteractionResponse, InteractionResponseBuilder>
{
    /// <summary>
    ///     Composes a message callback.
    /// </summary>
    public InteractionResponseBuilder WithMessage(Action<InteractionMessageDataBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new InteractionMessageDataBuilder();
        configure(builder);
        return WithType(InteractionCallbackType.ChannelMessageWithSource).WithData(builder.Build());
    }

    /// <summary>
    ///     Composes a modal callback.
    /// </summary>
    public InteractionResponseBuilder WithModal(Action<InteractionModalDataBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new InteractionModalDataBuilder();
        configure(builder);
        return WithType(InteractionCallbackType.Modal).WithData(builder.Build());
    }

    /// <summary>
    ///     Composes a autocomplete callback.
    /// </summary>
    public InteractionResponseBuilder WithAutocomplete(Action<InteractionAutocompleteDataBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new InteractionAutocompleteDataBuilder();
        configure(builder);
        return WithType(InteractionCallbackType.ApplicationCommandAutocompleteResult).WithData(builder.Build());
    }

    /// <summary>
    ///     Creates a deferred message acknowledgement.
    /// </summary>
    public InteractionResponseBuilder Defer(bool ephemeral = false)
    {
        return WithType(InteractionCallbackType.DeferredChannelMessageWithSource)
            .WithData(new InteractionMessageData { Flags = ephemeral ? MessageFlags.Ephemeral : 0 });
    }

    /// <summary>
    ///     Sets Type; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionResponseBuilder WithType(InteractionCallbackType value)
    {
        return Set("Type", value);
    }

    /// <summary>
    ///     Sets Data; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionResponseBuilder WithData(InteractionResponseData value)
    {
        return Set("Data", new Optional<InteractionResponseData>(value));
    }

    /// <summary>
    ///     Omits Data from the composition.
    /// </summary>
    public InteractionResponseBuilder OmitData()
    {
        return Set("Data", default(Optional<InteractionResponseData>));
    }
}