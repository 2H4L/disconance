namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Callback Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
public class InteractionCallbackResponse
{
    /// <summary>
    ///     The interaction object associated with the interaction response.
    /// </summary>
    /// <remarks>Discord field: <c>interaction</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public required InteractionCallback Interaction { get; set; }

    /// <summary>
    ///     The resource that was created by the interaction response.
    /// </summary>
    /// <remarks>Discord field: <c>resource</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<InteractionCallbackResource> Resource { get; set; }
}