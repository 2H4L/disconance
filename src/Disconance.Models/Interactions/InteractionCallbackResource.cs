using Disconance.Models.Messages;

namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Callback Resource data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
public class InteractionCallbackResource
{
    /// <summary>
    ///     Interaction callback type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public required InteractionCallbackType Type { get; set; }

    /// <summary>
    ///     Represents the Activity launched by this interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>activity_instance</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<InteractionCallbackActivityInstance> ActivityInstance { get; set; }

    /// <summary>
    ///     Message created by the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>message</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public Optional<Message> Message { get; set; }
}