namespace Disconance.Models.Components;

/// <summary>
///     Checkbox Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-interaction-response-structure" />
public class CheckboxInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>23</c> for a Checkbox.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#checkbox-interaction-response-structure" />
    public override ComponentType Type => ComponentType.Checkbox;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#checkbox-interaction-response-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The state of the checkbox (<c>true</c> if checked, <c>false</c> if unchecked).
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#checkbox-interaction-response-structure" />
    public required bool Value { get; set; }
}