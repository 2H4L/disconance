namespace Disconance.Models.Components;

/// <summary>
///     Text Display Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#text-display" />
public class TextDisplayInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>10</c> for a Text Display.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-display" />
    public override ComponentType Type => ComponentType.TextDisplay;
}