using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes FileUpload values. Discord limits are documented on the model.
/// </summary>
public sealed class FileUploadBuilder : ModelBuilder<FileUpload, FileUploadBuilder>
{
    /// <summary>
    ///     Sets CustomId; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithCustomId(string value)
    {
        return Set("CustomId", value);
    }

    /// <summary>
    ///     Sets MinValues; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithMinValues(int value)
    {
        return Set("MinValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MinValues from the composition.
    /// </summary>
    public FileUploadBuilder OmitMinValues()
    {
        return Set("MinValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets MaxValues; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithMaxValues(int value)
    {
        return Set("MaxValues", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits MaxValues from the composition.
    /// </summary>
    public FileUploadBuilder OmitMaxValues()
    {
        return Set("MaxValues", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Required; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithRequired(bool value)
    {
        return Set("Required", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Required from the composition.
    /// </summary>
    public FileUploadBuilder OmitRequired()
    {
        return Set("Required", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets FileTypes; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithFileTypes(List<string> value)
    {
        return Set("FileTypes", new Optional<List<string>>(value));
    }

    /// <summary>
    ///     Omits FileTypes from the composition.
    /// </summary>
    public FileUploadBuilder OmitFileTypes()
    {
        return Set("FileTypes", default(Optional<List<string>>));
    }

    /// <summary>
    ///     Appends one FileType.
    /// </summary>
    public FileUploadBuilder AddFileType(string value)
    {
        return Add("FileTypes", value);
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public FileUploadBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public FileUploadBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}