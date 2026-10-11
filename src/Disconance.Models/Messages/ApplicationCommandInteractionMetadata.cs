using Disconance.Models.Interactions;
using Disconance.Models.Users;

namespace Disconance.Models.Messages;

/// <summary>
///     Application Command Interaction Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
public class ApplicationCommandInteractionMetadata : MessageInteractionMetadata
{
    /// <summary>
    ///     The kind of interaction that produced the message.
    /// </summary>
    public override InteractionType Type => InteractionType.ApplicationCommand;

    /// <summary>
    ///     The user the command was run on, present only on user command interactions.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#user-commands" />
    public Optional<User> TargetUser { get; set; }

    /// <summary>
    ///     The ID of the message the command was run on, present only on message command interactions. The original
    ///     response message will also have <c>message_reference</c> and <c>referenced_message</c> pointing to this
    ///     message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_message_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#message-commands" />
    public Optional<Snowflake> TargetMessageId { get; set; }
}