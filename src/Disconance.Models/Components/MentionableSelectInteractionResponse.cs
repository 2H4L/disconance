using Disconance.Models.Interactions;

namespace Disconance.Models.Components;

/// <summary>
///     Mentionable Select Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
public class MentionableSelectInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>7</c> for a Mentionable Select.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public override ComponentType Type => Components.ComponentType.MentionableSelect;

    /// <summary>
    ///     <c>7</c> for a Mentionable Select.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>component_type</c> . Supplied in message component interactions; modal submissions use
    ///     type instead.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<ComponentType> ComponentType { get; set; }

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Resolved entities from selected options.
    /// </summary>
    /// <remarks>Discord field: <c>resolved</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public required ResolvedData Resolved { get; set; }

    /// <summary>
    ///     IDs of the selected mentionables.
    /// </summary>
    /// <remarks>Discord field: <c>values</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public required List<Snowflake> Values { get; set; }
}