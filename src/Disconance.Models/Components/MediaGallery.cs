namespace Disconance.Models.Components;

/// <summary>
///     Media Gallery data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#media-gallery-media-gallery-structure" />
public class MediaGallery : Component
{
    /// <summary>
    ///     <c>12</c> for media gallery component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#media-gallery-media-gallery-structure" />
    public override ComponentType Type => ComponentType.MediaGallery;

    /// <summary>
    ///     1 to 10 media gallery items.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>items</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#media-gallery-media-gallery-structure" />
    public required List<MediaGalleryItem> Items { get; set; }
}