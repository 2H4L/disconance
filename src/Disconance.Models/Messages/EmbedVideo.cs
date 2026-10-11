namespace Disconance.Models.Messages;

/// <summary>
///     Embed Video data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
public class EmbedVideo
{
    /// <summary>
    ///     Source url of video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<string> Url { get; set; }

    /// <summary>
    ///     A proxied url of the video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>proxy_url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<string> ProxyUrl { get; set; }

    /// <summary>
    ///     Height of video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>height</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<int> Height { get; set; }

    /// <summary>
    ///     Width of video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>width</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<int> Width { get; set; }

    /// <summary>
    ///     The video's media type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>content_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Media_type" />
    public Optional<string> ContentType { get; set; }

    /// <summary>
    ///     Thumbhash placeholder of the video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    /// <seealso href="https://evanw.github.io/thumbhash/" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     Version of the placeholder.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder_version</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<int> PlaceholderVersion { get; set; }

    /// <summary>
    ///     Description (alt text) for the video.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Embed media flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-video-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<EmbedMediaFlags> Flags { get; set; }
}