namespace Disconance.Models.Polls;

/// <summary>
///     Poll Answer Count data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
public class PollAnswerCount
{
    /// <summary>
    ///     The <c>answer_id</c> .
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
    public required int Id { get; set; }

    /// <summary>
    ///     The number of votes for this answer.
    /// </summary>
    /// <remarks>Discord field: <c>count</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
    public required int Count { get; set; }

    /// <summary>
    ///     Whether the current user voted for this answer.
    /// </summary>
    /// <remarks>Discord field: <c>me_voted</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-results-object" />
    public required bool MeVoted { get; set; }
}