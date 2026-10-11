namespace Disconance.Models.Polls;

/// <summary>
///     Poll data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
public class Poll
{
    /// <summary>
    ///     The question of the poll. Only <c>text</c> is supported.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>question</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public required PollMedia Question { get; set; }

    /// <summary>
    ///     Each of the answers available in the poll.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>answers</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public required List<PollAnswer> Answers { get; set; }

    /// <summary>
    ///     The time when the poll ends.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>expiry</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public required DateTimeOffset? Expiry { get; set; }

    /// <summary>
    ///     Whether a user can select multiple answers.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>allow_multiselect</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public required bool AllowMultiselect { get; set; }

    /// <summary>
    ///     The layout type of the poll.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>layout_type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public required PollLayoutType LayoutType { get; set; }

    /// <summary>
    ///     The results of the poll.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>results</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-object-poll-object-structure" />
    public Optional<PollResults> Results { get; set; }
}