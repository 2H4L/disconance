namespace Disconance.Models.Components;

/// <summary>
///     Media Gallery Item data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#media-gallery-media-gallery-item-structure" />
public class MediaGalleryItem
{
    /// <summary>
    ///     A url or attachment provided as an unfurled media item.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>media</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#media-gallery" />
    public required UnfurledMediaItem Media { get; set; }

    /// <summary>
    ///     Alt text for the media, max 1024 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#media-gallery" />
    public Optional<string?> Description { get; set; }

    /// <summary>
    ///     Whether the media should be a spoiler (or blurred out). Defaults to <c>false</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spoiler</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#media-gallery" />
    public Optional<bool> Spoiler { get; set; }
}