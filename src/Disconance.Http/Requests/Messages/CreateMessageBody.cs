using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     Writable fields for CreateMessageBody. Unassigned optional fields are omitted.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
public class CreateMessageBody
{
    /// <summary>
    ///     Discord field <c>content</c>; up to 2000 characters. Null on edit clears the content.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<string> Content { get; set; }

    /// <summary>
    ///     Discord field <c>tts</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<bool> Tts { get; set; }

    /// <summary>
    ///     Discord field <c>embeds</c>; up to 10 rich embeds and 6000 combined characters.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<List<Embed>> Embeds { get; set; }

    /// <summary>
    ///     Discord field <c>allowed_mentions</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<AllowedMentions> AllowedMentions { get; set; }

    /// <summary>
    ///     Discord field <c>components</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<List<Component>> Components { get; set; }

    /// <summary>
    ///     Discord field <c>attachments</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<List<PartialAttachment>> Attachments { get; set; }

    /// <summary>
    ///     Discord field <c>flags</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<MessageFlags> Flags { get; set; }

    /// <summary>
    ///     Discord field <c>poll</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<PollDefinition> Poll { get; set; }

    /// <summary>
    ///     Discord field <c>nonce</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<MessageNonce> Nonce { get; set; }

    /// <summary>
    ///     Discord field <c>enforce_nonce</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<bool> EnforceNonce { get; set; }

    /// <summary>
    ///     Discord field <c>message_reference</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<MessageReference> MessageReference { get; set; }

    /// <summary>
    ///     Discord field <c>sticker_ids</c>; up to 3 sticker IDs.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
    public Optional<List<Snowflake>> StickerIds { get; set; }
}