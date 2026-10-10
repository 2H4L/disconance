namespace Disconance.Models.Polls;

/// <summary>
///     Poll Answer data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/poll#poll-answer-object-poll-answer-object-structure" />
public class PollAnswer
{
    /// <summary>
    ///     The ID of the answer.
    /// </summary>
    /// <remarks>Discord field: <c>answer_id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/poll#poll-answer-object-poll-answer-object-structure" />
    public required int AnswerId { get; set; }

    /// <summary>
    ///     The data of the answer.
    /// </summary>
    /// <remarks>Discord field: <c>poll_media</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/poll#poll-answer-object-poll-answer-object-structure" />
    public required PollMedia PollMedia { get; set; }
}