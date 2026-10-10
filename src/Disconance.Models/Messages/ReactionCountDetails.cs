namespace Disconance.Models.Messages;

/// <summary>
///     Reaction Count Details data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#reaction-count-details-object" />
public class ReactionCountDetails
{
    /// <summary>
    ///     Count of super reactions.
    /// </summary>
    /// <remarks>Discord field: <c>burst</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-count-details-object" />
    public required int Burst { get; set; }

    /// <summary>
    ///     Count of normal reactions.
    /// </summary>
    /// <remarks>Discord field: <c>normal</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-count-details-object" />
    public required int Normal { get; set; }
}