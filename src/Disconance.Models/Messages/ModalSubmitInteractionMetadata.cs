using Disconance.Models.Interactions;

namespace Disconance.Models.Messages;

/// <summary>
///     Modal Submit Interaction Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
public class ModalSubmitInteractionMetadata : MessageInteractionMetadata
{
    /// <summary>
    ///     The kind of interaction that produced the message.
    /// </summary>
    public override InteractionType Type => InteractionType.ModalSubmit;

    /// <summary>
    ///     Metadata for the interaction that was used to open the modal.
    /// </summary>
    /// <remarks>Discord field: <c>triggering_interaction_metadata</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    public required MessageInteractionMetadata TriggeringInteractionMetadata { get; set; }
}