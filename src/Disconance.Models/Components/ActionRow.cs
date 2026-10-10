namespace Disconance.Models.Components;

/// <summary>
///     Action Row data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#action-row-action-row-structure" />
public class ActionRow : Component
{
    /// <summary>
    ///     <c>1</c> for action row component.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#action-row-action-row-structure" />
    public override ComponentType Type => ComponentType.ActionRow;

    /// <summary>
    ///     Up to 5 interactive button components or a single select component.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#action-row-action-row-structure" />
    public required List<Component> Components { get; set; }
}