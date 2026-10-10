namespace Disconance.Models.Components;

/// <summary>
///     Checkbox Group Interaction Response data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#checkbox-group-interaction-response-structure" />
public class CheckboxGroupInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>22</c> for a Checkbox Group.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group" />
    public override ComponentType Type => ComponentType.CheckboxGroup;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The values of the selected options, or an empty array <c>[]</c> if no options are selected.
    /// </summary>
    /// <remarks>Discord field: <c>values</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group" />
    public required List<string> Values { get; set; }
}