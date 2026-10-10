namespace Disconance.Models.Components;

/// <summary>
///     Text Input Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#text-input" />
public class TextInputInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>4</c> for a Text Input.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input" />
    public override ComponentType Type => ComponentType.TextInput;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The user's input text.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input" />
    public required string Value { get; set; }
}