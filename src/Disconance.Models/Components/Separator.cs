namespace Disconance.Models.Components;

/// <summary>
///     Separator data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#separator-separator-structure" />
public class Separator : Component
{
    /// <summary>
    ///     <c>14</c> for separator component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#separator-separator-structure" />
    public override ComponentType Type => ComponentType.Separator;

    /// <summary>
    ///     Whether a visual divider should be displayed in the component. Defaults to <c>true</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>divider</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#separator-separator-structure" />
    public Optional<bool> Divider { get; set; }

    /// <summary>
    ///     Size of separator padding—<c>1</c> for small padding, <c>2</c> for large padding. Defaults to <c>1</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spacing</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#separator-separator-structure" />
    public Optional<SeparatorSpacing> Spacing { get; set; }
}