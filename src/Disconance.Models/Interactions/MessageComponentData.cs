using Disconance.Models.Components;

namespace Disconance.Models.Interactions;

/// <summary>
///     Message Component Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class MessageComponentData : InteractionData
{
    /// <summary>
    ///     <c>custom_id</c> of the component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/components/reference#anatomy-of-a-component-custom-id" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Type of the component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>component_type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/components/reference#component-object-component-types" />
    public required ComponentType ComponentType { get; set; }

    /// <summary>
    ///     Values the user selected in a select menu component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/components/reference#string-select" />
    public Optional<List<string>> Values { get; set; }

    /// <summary>
    ///     Resolved entities from selected options.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>resolved</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<ResolvedData> Resolved { get; set; }
}