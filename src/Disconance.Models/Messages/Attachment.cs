using Disconance.Models.Applications;
using Disconance.Models.Users;

namespace Disconance.Models.Messages;

/// <summary>
///     Attachment data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
public class Attachment
{
    /// <summary>
    ///     Attachment id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Name of file attached.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>filename</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public required string Filename { get; set; }

    /// <summary>
    ///     The title of the file.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>title</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<string> Title { get; set; }

    /// <summary>
    ///     Description (alt text) for the file (max 1024 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     The attachment's media type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>content_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Media_type" />
    public Optional<string> ContentType { get; set; }

    /// <summary>
    ///     Size of file in bytes.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>size</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public required int Size { get; set; }

    /// <summary>
    ///     Source url of file.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public required string Url { get; set; }

    /// <summary>
    ///     A proxied url of file.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>proxy_url</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public required string ProxyUrl { get; set; }

    /// <summary>
    ///     Height of file (if image or video).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>height</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<int?> Height { get; set; }

    /// <summary>
    ///     Width of file (if image or video).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>width</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<int?> Width { get; set; }

    /// <summary>
    ///     Thumbhash placeholder (if image or video).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    /// <seealso href="https://evanw.github.io/thumbhash/" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     Version of the placeholder (if image or video).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder_version</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<int> PlaceholderVersion { get; set; }

    /// <summary>
    ///     Whether this attachment is ephemeral.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>ephemeral</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<bool> Ephemeral { get; set; }

    /// <summary>
    ///     The duration of the audio or video file.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>duration_secs</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<double> DurationSecs { get; set; }

    /// <summary>
    ///     Base64 encoded bytearray representing a sampled waveform (currently for voice messages).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>waveform</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<string> Waveform { get; set; }

    /// <summary>
    ///     Attachment flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<AttachmentFlags> Flags { get; set; }

    /// <summary>
    ///     For Clips, array of users who were in the stream.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>clip_participants</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<List<User>> ClipParticipants { get; set; }

    /// <summary>
    ///     For Clips, when the clip was created.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>clip_created_at</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<DateTimeOffset> ClipCreatedAt { get; set; }

    /// <summary>
    ///     For Clips, the application in the stream, if recognized.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-structure" />
    public Optional<Application?> Application { get; set; }
}