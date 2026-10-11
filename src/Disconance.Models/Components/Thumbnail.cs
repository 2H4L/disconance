namespace Disconance.Models.Components;

/// <summary>
///     Thumbnail data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#thumbnail-thumbnail-structure" />
public class Thumbnail : Component
{
    /// <summary>
    ///     <c>11</c> for thumbnail component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#thumbnail-thumbnail-structure" />
    public override ComponentType Type => ComponentType.Thumbnail;

    /// <summary>
    ///     A url or attachment provided as an unfurled media item.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>media</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#thumbnail-thumbnail-structure" />
    public required UnfurledMediaItem Media { get; set; }

    /// <summary>
    ///     Alt text for the media, max 1024 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#thumbnail-thumbnail-structure" />
    public Optional<string?> Description { get; set; }

    /// <summary>
    ///     Whether the thumbnail should be a spoiler (or blurred out). Defaults to <c>false</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spoiler</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#thumbnail-thumbnail-structure" />
    public Optional<bool> Spoiler { get; set; }
}