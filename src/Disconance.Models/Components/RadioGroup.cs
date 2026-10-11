namespace Disconance.Models.Components;

/// <summary>
///     Radio Group data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-structure" />
public class RadioGroup : Component
{
    /// <summary>
    ///     <c>21</c> for radio group.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-structure" />
    public override ComponentType Type => ComponentType.RadioGroup;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     List of options to show; min 2, max 10.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>options</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-structure" />
    public required List<RadioGroupOption> Options { get; set; }

    /// <summary>
    ///     Whether a selection is required to submit the modal (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-structure" />
    public Optional<bool> Required { get; set; }
}