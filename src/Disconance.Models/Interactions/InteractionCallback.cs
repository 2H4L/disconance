namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Callback data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
public class InteractionCallback
{
    /// <summary>
    ///     ID of the interaction.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Interaction type.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public required InteractionType Type { get; set; }

    /// <summary>
    ///     Instance ID of the Activity if one was launched or joined.
    /// </summary>
    /// <remarks>Discord field: <c>activity_instance_id</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<string> ActivityInstanceId { get; set; }

    /// <summary>
    ///     ID of the message that was created by the interaction.
    /// </summary>
    /// <remarks>Discord field: <c>response_message_id</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<Snowflake> ResponseMessageId { get; set; }

    /// <summary>
    ///     Whether the message is in a loading state.
    /// </summary>
    /// <remarks>Discord field: <c>response_message_loading</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<bool> ResponseMessageLoading { get; set; }

    /// <summary>
    ///     Whether the response message is ephemeral.
    /// </summary>
    /// <remarks>Discord field: <c>response_message_ephemeral</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<bool> ResponseMessageEphemeral { get; set; }
}