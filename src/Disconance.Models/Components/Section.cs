namespace Disconance.Models.Components;

/// <summary>
///     Section data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#section-section-structure" />
public class Section : Component
{
    /// <summary>
    ///     <c>9</c> for section component.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#section-section-structure" />
    public override ComponentType Type => ComponentType.Section;

    /// <summary>
    ///     One to three child components representing the content of the section that is contextually associated to the
    ///     accessory.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#section-section-structure" />
    public required List<Component> Components { get; set; }

    /// <summary>
    ///     A component that is contextually associated to the content of the section.
    /// </summary>
    /// <remarks>Discord field: <c>accessory</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#section-section-structure" />
    public required Component Accessory { get; set; }
}