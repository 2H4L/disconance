namespace Disconance.Models.Messages;

/// <summary>
///     Attachment Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#attachment-object-attachment-flags" />
[Flags]
public enum AttachmentFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This attachment is a Clip from a stream.
    /// </summary>
    /// <seealso href="https://support.discord.com/hc/en-us/articles/16861982215703" />
    IsClip = 1UL << 0,

    /// <summary>
    ///     This attachment is the thumbnail of a thread in a media channel, displayed in the grid but not on the
    ///     message.
    /// </summary>
    IsThumbnail = 1UL << 1,

    /// <summary>
    ///     This attachment has been edited using the remix feature on mobile (deprecated).
    /// </summary>
    IsRemix = 1UL << 2,

    /// <summary>
    ///     This attachment was marked as a spoiler and is blurred until clicked.
    /// </summary>
    IsSpoiler = 1UL << 3,

    /// <summary>
    ///     This attachment is an animated image.
    /// </summary>
    IsAnimated = 1UL << 5
}