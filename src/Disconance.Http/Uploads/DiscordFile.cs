namespace Disconance.Http.Uploads;

/// <summary>
///     A replayable upload. The sender owns every stream returned by OpenRead.
/// </summary>
public sealed class DiscordFile
{
    /// <summary>
    ///     Creates an upload. The factory must return a newly opened readable stream on every invocation.
    /// </summary>
    public DiscordFile(string filename, Func<Stream> openRead)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filename);
        ArgumentNullException.ThrowIfNull(openRead);

        if (filename.Contains('\r') || filename.Contains('\n'))
        {
            throw new ArgumentException("Invalid filename.", nameof(filename));
        }

        Filename = filename;
        OpenRead = openRead;
    }

    /// <summary>
    ///     The uploaded filename, also used by attachment:// references.
    /// </summary>
    public string Filename { get; }

    /// <summary>
    ///     Opens a new stream positioned at the start of its content.
    /// </summary>
    public Func<Stream> OpenRead { get; }

    /// <summary>
    ///     Optional attachment description.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     Content MIME type; defaults to application/octet-stream.
    /// </summary>
    public string ContentType { get; init; } = "application/octet-stream";
}