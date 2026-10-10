namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Response data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public class InteractionResponse
{
    /// <summary>
    ///     Type of response.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required InteractionCallbackType Type { get; set; }

    /// <summary>
    ///     An optional response message.
    /// </summary>
    /// <remarks>Discord field: <c>data</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<InteractionResponseData> Data { get; set; }
}