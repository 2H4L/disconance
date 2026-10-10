namespace Disconance.Models.Polls;

/// <summary>
///     Poll Create Request data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
public class PollDefinition
{
    /// <summary>
    ///     The question of the poll. Only <c>text</c> is supported.
    /// </summary>
    /// <remarks>Discord field: <c>question</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
    public required PollMedia Question { get; set; }

    /// <summary>
    ///     Each of the answers available in the poll, up to 10.
    /// </summary>
    /// <remarks>Discord field: <c>answers</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
    public required List<PollAnswerDefinition> Answers { get; set; }

    /// <summary>
    ///     Number of hours the poll should be open for, up to 32 days. Defaults to 24.
    /// </summary>
    /// <remarks>Discord field: <c>duration</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
    public Optional<int> Duration { get; set; }

    /// <summary>
    ///     Whether a user can select multiple answers. Defaults to false.
    /// </summary>
    /// <remarks>Discord field: <c>allow_multiselect</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
    public Optional<bool> AllowMultiselect { get; set; }

    /// <summary>
    ///     The layout type of the poll. Defaults to <c>DEFAULT</c> .
    /// </summary>
    /// <remarks>Discord field: <c>layout_type</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/poll#poll-create-request-object" />
    public Optional<PollLayoutType> LayoutType { get; set; }
}