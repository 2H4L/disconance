using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes EmbedImage values. Discord limits are documented on the model.
/// </summary>
public sealed class EmbedImageBuilder : ModelBuilder<EmbedImage, EmbedImageBuilder>
{
    /// <summary>
    ///     Sets Url; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithUrl(string value)
    {
        return Set("Url", value);
    }

    /// <summary>
    ///     Sets ProxyUrl; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithProxyUrl(string value)
    {
        return Set("ProxyUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ProxyUrl from the composition.
    /// </summary>
    public EmbedImageBuilder OmitProxyUrl()
    {
        return Set("ProxyUrl", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Height; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithHeight(int value)
    {
        return Set("Height", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Height from the composition.
    /// </summary>
    public EmbedImageBuilder OmitHeight()
    {
        return Set("Height", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Width; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithWidth(int value)
    {
        return Set("Width", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Width from the composition.
    /// </summary>
    public EmbedImageBuilder OmitWidth()
    {
        return Set("Width", default(Optional<int>));
    }

    /// <summary>
    ///     Sets ContentType; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithContentType(string value)
    {
        return Set("ContentType", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ContentType from the composition.
    /// </summary>
    public EmbedImageBuilder OmitContentType()
    {
        return Set("ContentType", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Placeholder; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithPlaceholder(string value)
    {
        return Set("Placeholder", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Placeholder from the composition.
    /// </summary>
    public EmbedImageBuilder OmitPlaceholder()
    {
        return Set("Placeholder", default(Optional<string>));
    }

    /// <summary>
    ///     Sets PlaceholderVersion; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithPlaceholderVersion(int value)
    {
        return Set("PlaceholderVersion", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits PlaceholderVersion from the composition.
    /// </summary>
    public EmbedImageBuilder OmitPlaceholderVersion()
    {
        return Set("PlaceholderVersion", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public EmbedImageBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Flags; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedImageBuilder WithFlags(EmbedMediaFlags value)
    {
        return Set("Flags", new Optional<EmbedMediaFlags>(value));
    }

    /// <summary>
    ///     Omits Flags from the composition.
    /// </summary>
    public EmbedImageBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<EmbedMediaFlags>));
    }
}