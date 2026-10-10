using Disconance.Models.Components;

namespace Disconance.Models.Interactions;

/// <summary>
///     Modal Submit Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class ModalSubmitData : InteractionData
{
    /// <summary>
    ///     The custom ID provided for the modal.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Values submitted by the user.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required List<ComponentInteractionResponse> Components { get; set; }

    /// <summary>
    ///     Resolved entities from selected options.
    /// </summary>
    /// <remarks>Discord field: <c>resolved</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<ResolvedData> Resolved { get; set; }
}