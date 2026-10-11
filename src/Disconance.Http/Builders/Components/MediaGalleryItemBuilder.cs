using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes MediaGalleryItem values. Discord limits are documented on the model.
/// </summary>
public sealed class MediaGalleryItemBuilder : ModelBuilder<MediaGalleryItem, MediaGalleryItemBuilder>
{
    /// <summary>
    ///     Sets Media; explicit values, including defaults, remain present.
    /// </summary>
    public MediaGalleryItemBuilder WithMedia(UnfurledMediaItem value)
    {
        return Set("Media", value);
    }

    /// <summary>
    ///     Composes Media with a nested builder.
    /// </summary>
    public MediaGalleryItemBuilder WithMedia(Action<UnfurledMediaItemBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UnfurledMediaItemBuilder();
        configure(builder);
        return WithMedia(builder.Build());
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public MediaGalleryItemBuilder WithDescription(string? value)
    {
        return Set("Description", new Optional<string?>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public MediaGalleryItemBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string?>));
    }

    /// <summary>
    ///     Sets Spoiler; explicit values, including defaults, remain present.
    /// </summary>
    public MediaGalleryItemBuilder WithSpoiler(bool value)
    {
        return Set("Spoiler", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Spoiler from the composition.
    /// </summary>
    public MediaGalleryItemBuilder OmitSpoiler()
    {
        return Set("Spoiler", default(Optional<bool>));
    }
}