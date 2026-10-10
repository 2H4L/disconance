using Disconance.Models.Applications;
using Disconance.Models.Interactions;
using Disconance.Models.Users;

namespace Disconance.Models.Messages;

/// <summary>
///     Shared metadata describing the interaction that produced a message.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
public abstract class MessageInteractionMetadata
{
    /// <summary>
    ///     ID of the interaction.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of interaction.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    public abstract InteractionType Type { get; }

    /// <summary>
    ///     User who triggered the interaction.
    /// </summary>
    /// <remarks>Discord field: <c>user</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    public required User User { get; set; }

    /// <summary>
    ///     IDs for installation context(s) related to an interaction. Details in Authorizing Integration Owners Object.
    /// </summary>
    /// <remarks>Discord field: <c>authorizing_integration_owners</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required Dictionary<ApplicationIntegrationType, Snowflake> AuthorizingIntegrationOwners { get; set; }

    /// <summary>
    ///     ID of the original response message, present only on follow-up messages.
    /// </summary>
    /// <remarks>Discord field: <c>original_response_message_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-interaction-metadata-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<Snowflake> OriginalResponseMessageId { get; set; }
}