namespace Disconance.Models.Components;

/// <summary>
///     A legacy modal action row containing submitted inputs.
/// </summary>
/// <remarks>Discord recommends labels for new modals; older modal submissions may contain action rows.</remarks>
/// <seealso href="https://docs.discord.com/developers/components/reference#action-row" />
public class ActionRowInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     Identifies an action row.
    /// </summary>
    public override ComponentType Type => ComponentType.ActionRow;

    /// <summary>
    ///     The submitted child inputs.
    /// </summary>
    public required List<ComponentInteractionResponse> Components { get; set; }
}