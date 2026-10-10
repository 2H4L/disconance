using Disconance.Models.Emojis;

namespace Disconance.Models.Messages;

/// <summary>
///     Reaction data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
public class Reaction
{
    /// <summary>
    ///     Total number of times this emoji has been used to react (including super reacts).
    /// </summary>
    /// <remarks>Discord field: <c>count</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required int Count { get; set; }

    /// <summary>
    ///     Reaction count details object.
    /// </summary>
    /// <remarks>Discord field: <c>count_details</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required ReactionCountDetails CountDetails { get; set; }

    /// <summary>
    ///     Whether the current user reacted using this emoji.
    /// </summary>
    /// <remarks>Discord field: <c>me</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required bool Me { get; set; }

    /// <summary>
    ///     Whether the current user super-reacted using this emoji.
    /// </summary>
    /// <remarks>Discord field: <c>me_burst</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required bool MeBurst { get; set; }

    /// <summary>
    ///     Emoji information.
    /// </summary>
    /// <remarks>Discord field: <c>emoji</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required PartialEmoji Emoji { get; set; }

    /// <summary>
    ///     HEX colors used for super reaction.
    /// </summary>
    /// <remarks>Discord field: <c>burst_colors</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#reaction-object-reaction-structure" />
    public required List<string> BurstColors { get; set; }
}