namespace Disconance.Models.Polls;

/// <summary>
///     An answer supplied when defining a poll, before Discord assigns its answer ID.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/poll#poll-answer-object-poll-answer-object-structure" />
public class PollAnswerDefinition
{
    /// <summary>
    ///     The text and emoji displayed for this answer.
    /// </summary>
    public required PollMedia PollMedia { get; set; }
}