namespace Disconance.Models.Components;

/// <summary>
///     Container data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#container-container-structure" />
public class Container : Component
{
    /// <summary>
    ///     <c>17</c> for container component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#container-container-structure" />
    public override ComponentType Type => ComponentType.Container;

    /// <summary>
    ///     Child components that are encapsulated within the Container.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>components</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#container-container-structure" />
    public required List<Component> Components { get; set; }

    /// <summary>
    ///     Color for the accent on the container as RGB from <c>0x000000</c> to <c>0xFFFFFF</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>accent_color</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#container-container-structure" />
    public Optional<int?> AccentColor { get; set; }

    /// <summary>
    ///     Whether the container should be a spoiler (or blurred out). Defaults to <c>false</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spoiler</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#container-container-structure" />
    public Optional<bool> Spoiler { get; set; }
}