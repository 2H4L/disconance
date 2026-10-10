namespace Disconance.Models.Components;

/// <summary>
///     Text Display data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#text-display-text-display-structure" />
public class TextDisplay : Component
{
    /// <summary>
    ///     <c>10</c> for text display.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-display-text-display-structure" />
    public override ComponentType Type => ComponentType.TextDisplay;

    /// <summary>
    ///     Text that will be displayed similar to a message.
    /// </summary>
    /// <remarks>Discord field: <c>content</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-display-text-display-structure" />
    public required string Content { get; set; }
}