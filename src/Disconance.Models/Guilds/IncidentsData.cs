namespace Disconance.Models.Guilds;

/// <summary>
///     Incidents Data data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#incidents-data-object-incidents-data-structure" />
public class IncidentsData
{
    /// <summary>
    ///     When invites get enabled again.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>invites_disabled_until</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#incidents-data-object-incidents-data-structure" />
    public required DateTimeOffset? InvitesDisabledUntil { get; set; }

    /// <summary>
    ///     When direct messages get enabled again.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>dms_disabled_until</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#incidents-data-object-incidents-data-structure" />
    public required DateTimeOffset? DmsDisabledUntil { get; set; }

    /// <summary>
    ///     When the dm spam was detected.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>dm_spam_detected_at</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#incidents-data-object-incidents-data-structure" />
    public Optional<DateTimeOffset?> DmSpamDetectedAt { get; set; }

    /// <summary>
    ///     When the raid was detected.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>raid_detected_at</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#incidents-data-object-incidents-data-structure" />
    public Optional<DateTimeOffset?> RaidDetectedAt { get; set; }
}