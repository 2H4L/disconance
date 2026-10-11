using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Thumbnail values. Discord limits are documented on the model.
/// </summary>
public sealed class ThumbnailBuilder : ModelBuilder<Thumbnail, ThumbnailBuilder>
{
    /// <summary>
    ///     Sets Media; explicit values, including defaults, remain present.
    /// </summary>
    public ThumbnailBuilder WithMedia(UnfurledMediaItem value)
    {
        return Set("Media", value);
    }

    /// <summary>
    ///     Composes Media with a nested builder.
    /// </summary>
    public ThumbnailBuilder WithMedia(Action<UnfurledMediaItemBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UnfurledMediaItemBuilder();
        configure(builder);
        return WithMedia(builder.Build());
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public ThumbnailBuilder WithDescription(string? value)
    {
        return Set("Description", new Optional<string?>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public ThumbnailBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string?>));
    }

    /// <summary>
    ///     Sets Spoiler; explicit values, including defaults, remain present.
    /// </summary>
    public ThumbnailBuilder WithSpoiler(bool value)
    {
        return Set("Spoiler", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Spoiler from the composition.
    /// </summary>
    public ThumbnailBuilder OmitSpoiler()
    {
        return Set("Spoiler", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public ThumbnailBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public ThumbnailBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}