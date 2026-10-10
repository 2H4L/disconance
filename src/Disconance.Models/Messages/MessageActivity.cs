namespace Disconance.Models.Messages;

/// <summary>
///     Message Activity data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-activity-structure" />
public class MessageActivity
{
    /// <summary>
    ///     Type of message activity.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/message#message-object-message-activity-structure" />
    public required MessageActivityType Type { get; set; }

    /// <summary>
    ///     party_id from a Rich Presence event.
    /// </summary>
    /// <remarks>Discord field: <c>party_id</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/message#message-object-message-activity-structure" />
    public Optional<string> PartyId { get; set; }
}