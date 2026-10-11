namespace Disconance.Models.Messages;

/// <summary>
///     Embed Footer data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-footer-structure" />
public class EmbedFooter
{
    /// <summary>
    ///     Footer text.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>text</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-footer-structure" />
    public required string Text { get; set; }

    /// <summary>
    ///     Url of footer icon (only supports http(s) and attachments).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-footer-structure" />
    public Optional<string> IconUrl { get; set; }

    /// <summary>
    ///     A proxied url of footer icon.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>proxy_icon_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-footer-structure" />
    public Optional<string> ProxyIconUrl { get; set; }
}