using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Requests.Interactions;

/// <summary>
///     Writable fields for EditInteractionMessageBody. Unassigned optional fields are omitted.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
public class EditInteractionMessageBody
{
    /// <summary>
    ///     Discord field <c>content</c>; up to 2000 characters. Null on edit clears the content.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<string?> Content { get; set; }

    /// <summary>
    ///     Discord field <c>embeds</c>; up to 10 rich embeds and 6000 combined characters.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<List<Embed>?> Embeds { get; set; }

    /// <summary>
    ///     Discord field <c>allowed_mentions</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<AllowedMentions?> AllowedMentions { get; set; }

    /// <summary>
    ///     Discord field <c>components</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<List<Component>?> Components { get; set; }

    /// <summary>
    ///     Discord field <c>attachments</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<List<PartialAttachment>?> Attachments { get; set; }

    /// <summary>
    ///     Discord field <c>flags</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<MessageFlags?> Flags { get; set; }

    /// <summary>
    ///     Discord field <c>poll</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#edit-original-interaction-response" />
    public Optional<PollDefinition?> Poll { get; set; }
}