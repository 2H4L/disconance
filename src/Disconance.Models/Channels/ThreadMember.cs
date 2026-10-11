using Disconance.Models.Guilds;

namespace Disconance.Models.Channels;

/// <summary>
///     Thread Member data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
public class ThreadMember
{
    /// <summary>
    ///     ID of the thread.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     ID of the user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
    public Optional<Snowflake> UserId { get; set; }

    /// <summary>
    ///     Time the user last joined the thread.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>join_timestamp</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
    public required DateTimeOffset JoinTimestamp { get; set; }

    /// <summary>
    ///     Any user-thread settings, currently only used for notifications.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
    public required int Flags { get; set; }

    /// <summary>
    ///     Additional information about the user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/channel#thread-member-object-thread-member-structure" />
    public Optional<GuildMember> Member { get; set; }
}