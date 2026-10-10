namespace Disconance.Models.Components;

/// <summary>
///     Label Interaction Response data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#label-label-interaction-response-structure" />
public class LabelInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>18</c> for a Label.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label" />
    public override ComponentType Type => ComponentType.Label;

    /// <summary>
    ///     The component within the label.
    /// </summary>
    /// <remarks>Discord field: <c>component</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label" />
    public required ComponentInteractionResponse Component { get; set; }
}