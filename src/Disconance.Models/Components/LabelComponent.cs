namespace Disconance.Models.Components;

/// <summary>
///     Label data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#label-label-structure" />
public class LabelComponent : Component
{
    /// <summary>
    ///     <c>18</c> for a label.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label-label-structure" />
    public override ComponentType Type => ComponentType.Label;

    /// <summary>
    ///     The label text; max 45 characters.
    /// </summary>
    /// <remarks>Discord field: <c>label</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label-label-structure" />
    public required string Label { get; set; }

    /// <summary>
    ///     An optional description text for the label; max 100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label-label-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     The component within the label.
    /// </summary>
    /// <remarks>Discord field: <c>component</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#label-label-structure" />
    public required Component Component { get; set; }
}