namespace Disconance.Models.Components;

/// <summary>
///     String Select Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
public class StringSelectInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>3</c> for a String Select.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
    public override ComponentType Type => Components.ComponentType.StringSelect;

    /// <summary>
    ///     <c>3</c> for a String Select.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>component_type</c> . Supplied in message component interactions; modal submissions use
    ///     type instead.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
    public Optional<ComponentType> ComponentType { get; set; }

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The text of the selected options.
    /// </summary>
    /// <remarks>Discord field: <c>values</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
    public required List<string> Values { get; set; }
}