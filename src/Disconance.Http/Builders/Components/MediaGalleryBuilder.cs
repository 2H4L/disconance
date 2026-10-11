using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes MediaGallery values. Discord limits are documented on the model.
/// </summary>
public sealed class MediaGalleryBuilder : ModelBuilder<MediaGallery, MediaGalleryBuilder>
{
    /// <summary>
    ///     Sets Items; explicit values, including defaults, remain present.
    /// </summary>
    public MediaGalleryBuilder WithItems(List<MediaGalleryItem> value)
    {
        return Set("Items", value);
    }

    /// <summary>
    ///     Appends one Item.
    /// </summary>
    public MediaGalleryBuilder AddItem(MediaGalleryItem value)
    {
        return Add("Items", value);
    }

    /// <summary>
    ///     Composes and appends MediaGalleryItem.
    /// </summary>
    public MediaGalleryBuilder AddItem(Action<MediaGalleryItemBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryItemBuilder();
        configure(builder);
        return AddItem(builder.Build());
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public MediaGalleryBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public MediaGalleryBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}