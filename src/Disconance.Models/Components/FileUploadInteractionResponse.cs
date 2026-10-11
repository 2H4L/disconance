namespace Disconance.Models.Components;

/// <summary>
///     File Upload Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#file-upload" />
public class FileUploadInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>19</c> for a File Upload.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload" />
    public override ComponentType Type => ComponentType.FileUpload;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     IDs of the uploaded files found in the resolved data.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>values</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-upload" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required List<Snowflake> Values { get; set; }
}