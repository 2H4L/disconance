using Disconance.Models.Interactions;

namespace Disconance.Models.Messages;

/// <summary>
///     Message Component Interaction Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
public class MessageComponentInteractionMetadata : MessageInteractionMetadata
{
    /// <summary>
    ///     The kind of interaction that produced the message.
    /// </summary>
    public override InteractionType Type => InteractionType.MessageComponent;

    /// <summary>
    ///     ID of the message that contained the interactive component.
    /// </summary>
    /// <remarks>Discord field: <c>interacted_message_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    public required Snowflake InteractedMessageId { get; set; }
}