using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Models.Interactions;

/// <summary>
///     Messages data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public class InteractionMessageData : InteractionResponseData
{
    /// <summary>
    ///     Whether the response is TTS.
    /// </summary>
    /// <remarks>Discord field: <c>tts</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<bool> Tts { get; set; }

    /// <summary>
    ///     Message content.
    /// </summary>
    /// <remarks>Discord field: <c>content</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<string> Content { get; set; }

    /// <summary>
    ///     Supports up to 10 embeds.
    /// </summary>
    /// <remarks>Discord field: <c>embeds</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<List<Embed>> Embeds { get; set; }

    /// <summary>
    ///     Allowed mentions object.
    /// </summary>
    /// <remarks>Discord field: <c>allowed_mentions</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    /// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
    public Optional<AllowedMentions> AllowedMentions { get; set; }

    /// <summary>
    ///     Message flags combined as a bitfield (only <c>SUPPRESS_EMBEDS</c> , <c>EPHEMERAL</c> ,
    ///     <c>IS_COMPONENTS_V2</c> , <c>IS_VOICE_MESSAGE</c> , and <c>SUPPRESS_NOTIFICATIONS</c> can be set).
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-flags" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<MessageFlags> Flags { get; set; }

    /// <summary>
    ///     Message components.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<List<Component>> Components { get; set; }

    /// <summary>
    ///     Attachment objects with filename and description.
    /// </summary>
    /// <remarks>Discord field: <c>attachments</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<List<PartialAttachment>> Attachments { get; set; }

    /// <summary>
    ///     Details about the poll.
    /// </summary>
    /// <remarks>Discord field: <c>poll</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<PollDefinition> Poll { get; set; }
}