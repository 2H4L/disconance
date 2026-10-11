namespace Disconance.Models.Channels;

/// <summary>
///     Thread Metadata data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/channel#thread-metadata-object-thread-metadata-structure" />
public class ThreadMetadata
{
    /// <summary>
    ///     Whether the thread is archived.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>archived</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public required bool Archived { get; set; }

    /// <summary>
    ///     The thread will stop showing in the channel list after <c>auto_archive_duration</c> minutes of inactivity,
    ///     can be set to: 60, 1440, 4320, 10080.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>auto_archive_duration</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public required int AutoArchiveDuration { get; set; }

    /// <summary>
    ///     Timestamp when the thread's archive status was last changed, used for calculating recent activity.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>archive_timestamp</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public required DateTimeOffset ArchiveTimestamp { get; set; }

    /// <summary>
    ///     Whether the thread is locked; when a thread is locked, only users with MANAGE_THREADS can unarchive it.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>locked</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public required bool Locked { get; set; }

    /// <summary>
    ///     Whether non-moderators can add other non-moderators to a thread; only available on private threads.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>invitable</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public Optional<bool> Invitable { get; set; }

    /// <summary>
    ///     Timestamp when the thread was created; only populated for threads created after 2022-01-09.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>create_timestamp</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-metadata-object" />
    public Optional<DateTimeOffset?> CreateTimestamp { get; set; }
}