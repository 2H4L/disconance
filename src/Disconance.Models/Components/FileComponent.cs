namespace Disconance.Models.Components;

/// <summary>
///     File data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
public class FileComponent : Component
{
    /// <summary>
    ///     <c>13</c> for a file component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
    public override ComponentType Type => ComponentType.File;

    /// <summary>
    ///     This unfurled media item is unique in that it only supports attachment references using the
    ///     <c>attachment://&lt;filename&gt;</c> syntax.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>file</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
    public required UnfurledMediaItem File { get; set; }

    /// <summary>
    ///     Whether the media should be a spoiler (or blurred out). Defaults to <c>false</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spoiler</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
    public Optional<bool> Spoiler { get; set; }

    /// <summary>
    ///     The name of the file. This field is ignored and provided by the API as part of the response.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     The size of the file in bytes. This field is ignored and provided by the API as part of the response.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>size</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#file-file-structure" />
    public Optional<int> Size { get; set; }
}