namespace Disconance.Models.Polls;

/// <summary>
///     Poll Results data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/poll#poll-results-object-poll-results-object-structure" />
public class PollResults
{
    /// <summary>
    ///     Whether the votes have been precisely counted.
    /// </summary>
    /// <remarks>Discord field: <c>is_finalized</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
    public required bool IsFinalized { get; set; }

    /// <summary>
    ///     The counts for each answer.
    /// </summary>
    /// <remarks>Discord field: <c>answer_counts</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
    public required List<PollAnswerCount> AnswerCounts { get; set; }
}