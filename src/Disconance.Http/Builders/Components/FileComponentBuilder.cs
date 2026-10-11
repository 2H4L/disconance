using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes FileComponent values. Discord limits are documented on the model.
/// </summary>
public sealed class FileComponentBuilder : ModelBuilder<FileComponent, FileComponentBuilder>
{
    /// <summary>
    ///     Sets File; explicit values, including defaults, remain present.
    /// </summary>
    public FileComponentBuilder WithFile(UnfurledMediaItem value)
    {
        return Set("File", value);
    }

    /// <summary>
    ///     Composes File with a nested builder.
    /// </summary>
    public FileComponentBuilder WithFile(Action<UnfurledMediaItemBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UnfurledMediaItemBuilder();
        configure(builder);
        return WithFile(builder.Build());
    }

    /// <summary>
    ///     Sets Spoiler; explicit values, including defaults, remain present.
    /// </summary>
    public FileComponentBuilder WithSpoiler(bool value)
    {
        return Set("Spoiler", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Spoiler from the composition.
    /// </summary>
    public FileComponentBuilder OmitSpoiler()
    {
        return Set("Spoiler", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Name; explicit values, including defaults, remain present.
    /// </summary>
    public FileComponentBuilder WithName(string value)
    {
        return Set("Name", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Name from the composition.
    /// </summary>
    public FileComponentBuilder OmitName()
    {
        return Set("Name", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Size; explicit values, including defaults, remain present.
    /// </summary>
    public FileComponentBuilder WithSize(int value)
    {
        return Set("Size", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Size from the composition.
    /// </summary>
    public FileComponentBuilder OmitSize()
    {
        return Set("Size", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public FileComponentBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public FileComponentBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}