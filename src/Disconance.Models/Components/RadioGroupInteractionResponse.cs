namespace Disconance.Models.Components;

/// <summary>
///     Radio Group Interaction Response data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#radio-group-interaction-response-structure" />
public class RadioGroupInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>21</c> for a Radio Group.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group" />
    public override ComponentType Type => ComponentType.RadioGroup;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The value of the selected option, or <c>null</c> if no option is selected.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>value</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group" />
    public required string? Value { get; set; }
}