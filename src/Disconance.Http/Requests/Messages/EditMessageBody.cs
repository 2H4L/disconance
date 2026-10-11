using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     Writable fields for EditMessageBody. Unassigned optional fields are omitted.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
public class EditMessageBody
{
    /// <summary>
    ///     Discord field <c>content</c>; up to 2000 characters. Null on edit clears the content.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<string?> Content { get; set; }

    /// <summary>
    ///     Discord field <c>embeds</c>; up to 10 rich embeds and 6000 combined characters.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<List<Embed>?> Embeds { get; set; }

    /// <summary>
    ///     Discord field <c>allowed_mentions</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<AllowedMentions?> AllowedMentions { get; set; }

    /// <summary>
    ///     Discord field <c>components</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<List<Component>?> Components { get; set; }

    /// <summary>
    ///     Discord field <c>attachments</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<List<PartialAttachment>?> Attachments { get; set; }

    /// <summary>
    ///     Discord field <c>flags</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
    public Optional<MessageFlags?> Flags { get; set; }
}