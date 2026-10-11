namespace Disconance.Models.Messages;

/// <summary>
///     Embed Author data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-author-structure" />
public class EmbedAuthor
{
    /// <summary>
    ///     Name of author.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-author-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Url of author (only supports http(s)).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-author-structure" />
    public Optional<string> Url { get; set; }

    /// <summary>
    ///     Url of author icon (only supports http(s) and attachments).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-author-structure" />
    public Optional<string> IconUrl { get; set; }

    /// <summary>
    ///     A proxied url of author icon.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>proxy_icon_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-author-structure" />
    public Optional<string> ProxyIconUrl { get; set; }
}