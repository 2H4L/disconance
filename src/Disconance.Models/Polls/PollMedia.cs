using Disconance.Models.Emojis;

namespace Disconance.Models.Polls;

/// <summary>
///     Poll Media data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/poll#poll-media-object-poll-media-object-structure" />
public class PollMedia
{
    /// <summary>
    ///     The text of the field.
    /// </summary>
    /// <remarks>Discord field: <c>text</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/poll#poll-media-object-poll-media-object-structure" />
    public Optional<string> Text { get; set; }

    /// <summary>
    ///     The emoji of the field.
    /// </summary>
    /// <remarks>Discord field: <c>emoji</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/poll#poll-media-object-poll-media-object-structure" />
    public Optional<PartialEmoji> Emoji { get; set; }
}