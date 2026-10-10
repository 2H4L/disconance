namespace Disconance.Models.Components;

/// <summary>
///     Unfurled Media Item data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
public class UnfurledMediaItem
{
    /// <summary>
    ///     Supports arbitrary urls and <c>attachment://&lt;filename&gt;</c> references.
    /// </summary>
    /// <remarks>Discord field: <c>url</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public required string Url { get; set; }

    /// <summary>
    ///     The proxied url of the media item.
    /// </summary>
    /// <remarks>Discord field: <c>proxy_url</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public Optional<string> ProxyUrl { get; set; }

    /// <summary>
    ///     The height of the media item (if image or video).
    /// </summary>
    /// <remarks>Discord field: <c>height</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public Optional<int?> Height { get; set; }

    /// <summary>
    ///     The width of the media item (if image or video).
    /// </summary>
    /// <remarks>Discord field: <c>width</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public Optional<int?> Width { get; set; }

    /// <summary>
    ///     Thumbhash placeholder (if image or video).
    /// </summary>
    /// <remarks>Discord field: <c>placeholder</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    /// <seealso href="https://evanw.github.io/thumbhash/" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     Version of the placeholder (if image or video).
    /// </summary>
    /// <remarks>Discord field: <c>placeholder_version</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public Optional<int> PlaceholderVersion { get; set; }

    /// <summary>
    ///     The media type of the content.
    /// </summary>
    /// <remarks>Discord field: <c>content_type</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    /// <seealso href="https://en.wikipedia.org/wiki/Media_type" />
    public Optional<string> ContentType { get; set; }

    /// <summary>
    ///     Unfurled media item flags combined as a bitfield.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<UnfurledMediaItemFlags> Flags { get; set; }

    /// <summary>
    ///     The id of the uploaded attachment.
    /// </summary>
    /// <remarks>Discord field: <c>attachment_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#unfurled-media-item" />
    public Optional<Snowflake> AttachmentId { get; set; }
}