namespace Disconance.Models.Messages;

/// <summary>
///     Embed Image data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
public class EmbedImage
{
    /// <summary>
    ///     Source url of image (only supports http(s) and attachments).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public required string Url { get; set; }

    /// <summary>
    ///     A proxied url of the image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>proxy_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public Optional<string> ProxyUrl { get; set; }

    /// <summary>
    ///     Height of image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>height</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public Optional<int> Height { get; set; }

    /// <summary>
    ///     Width of image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>width</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public Optional<int> Width { get; set; }

    /// <summary>
    ///     The image's media type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>content_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Media_type" />
    public Optional<string> ContentType { get; set; }

    /// <summary>
    ///     Thumbhash placeholder of the image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    /// <seealso href="https://evanw.github.io/thumbhash/" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     Version of the placeholder.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder_version</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public Optional<int> PlaceholderVersion { get; set; }

    /// <summary>
    ///     Description (alt text) for the image.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Embed media flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-image-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<EmbedMediaFlags> Flags { get; set; }
}