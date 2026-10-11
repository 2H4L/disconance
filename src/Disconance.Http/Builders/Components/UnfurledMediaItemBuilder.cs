using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes UnfurledMediaItem values. Discord limits are documented on the model.
/// </summary>
public sealed class UnfurledMediaItemBuilder : ModelBuilder<UnfurledMediaItem, UnfurledMediaItemBuilder>
{
    /// <summary>
    ///     Sets Url; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithUrl(string value)
    {
        return Set("Url", value);
    }

    /// <summary>
    ///     Sets ProxyUrl; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithProxyUrl(string value)
    {
        return Set("ProxyUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ProxyUrl from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitProxyUrl()
    {
        return Set("ProxyUrl", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Height; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithHeight(int? value)
    {
        return Set("Height", new Optional<int?>(value));
    }

    /// <summary>
    ///     Omits Height from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitHeight()
    {
        return Set("Height", default(Optional<int?>));
    }

    /// <summary>
    ///     Sets Width; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithWidth(int? value)
    {
        return Set("Width", new Optional<int?>(value));
    }

    /// <summary>
    ///     Omits Width from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitWidth()
    {
        return Set("Width", default(Optional<int?>));
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets PlaceholderVersion; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithPlaceholderVersion(int value)
    {
        return Set("PlaceholderVersion", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits PlaceholderVersion from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitPlaceholderVersion()
    {
        return Set("PlaceholderVersion", default(Optional<int>));
    }

    /// <summary>
    ///     Sets ContentType; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithContentType(string value)
    {
        return Set("ContentType", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ContentType from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitContentType()
    {
        return Set("ContentType", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Flags; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithFlags(UnfurledMediaItemFlags value)
    {
        return Set("Flags", new Optional<UnfurledMediaItemFlags>(value));
    }

    /// <summary>
    ///     Omits Flags from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<UnfurledMediaItemFlags>));
    }

    /// <summary>
    ///     Sets AttachmentId; explicit values, including defaults, remain present.
    /// </summary>
    public UnfurledMediaItemBuilder WithAttachmentId(Snowflake value)
    {
        return Set("AttachmentId", new Optional<Snowflake>(value));
    }

    /// <summary>
    ///     Omits AttachmentId from the composition.
    /// </summary>
    public UnfurledMediaItemBuilder OmitAttachmentId()
    {
        return Set("AttachmentId", default(Optional<Snowflake>));
    }
}