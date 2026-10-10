namespace Disconance.Models.Components;

/// <summary>
///     File Upload data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
public class FileUpload : Component
{
    /// <summary>
    ///     <c>19</c> for file upload.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    public override ComponentType Type => ComponentType.FileUpload;

    /// <summary>
    ///     ID for the file upload; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Minimum number of items that must be uploaded (defaults to 1); min 0 (see note), max 10.
    /// </summary>
    /// <remarks>Discord field: <c>min_values</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    public Optional<int> MinValues { get; set; }

    /// <summary>
    ///     Maximum number of items that can be uploaded (defaults to 1); max 10.
    /// </summary>
    /// <remarks>Discord field: <c>max_values</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    public Optional<int> MaxValues { get; set; }

    /// <summary>
    ///     Whether the file upload requires files to be uploaded before submitting the modal (defaults to <c>true</c>
    ///     ).
    /// </summary>
    /// <remarks>Discord field: <c>required</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     File types to filter for; can be <c>image</c> , <c>video</c> , <c>audio</c> , or any dot-prefixed extension
    ///     such as <c>.pdf</c> ; max 10.
    /// </summary>
    /// <remarks>Discord field: <c>file_types</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload-file-upload-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#file-type-filtering" />
    public Optional<List<string>> FileTypes { get; set; }
}