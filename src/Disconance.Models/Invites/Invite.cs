using Disconance.Models.Applications;
using Disconance.Models.Channels;
using Disconance.Models.Guilds;
using Disconance.Models.Guilds.ScheduledEvents;
using Disconance.Models.Permissions;
using Disconance.Models.Users;

namespace Disconance.Models.Invites;

/// <summary>
///     Invite data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
public class Invite
{
    /// <summary>
    ///     The type of invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public required InviteType Type { get; set; }

    /// <summary>
    ///     The invite code (unique ID).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>code</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public required string Code { get; set; }

    /// <summary>
    ///     The guild this invite is for.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<PartialGuild> Guild { get; set; }

    /// <summary>
    ///     The channel this invite is for.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public required PartialChannel? Channel { get; set; }

    /// <summary>
    ///     The user who created the invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>inviter</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<User> Inviter { get; set; }

    /// <summary>
    ///     The type of target for this voice channel invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<InviteTargetType> TargetType { get; set; }

    /// <summary>
    ///     The user whose stream to display for this voice channel stream invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<User> TargetUser { get; set; }

    /// <summary>
    ///     The embedded application to open for this voice channel embedded application invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_application</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<PartialApplication> TargetApplication { get; set; }

    /// <summary>
    ///     Approximate count of online members, returned from the <c>GET /invites/&lt;code&gt;</c> endpoint when
    ///     <c>with_counts</c> is <c>true</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>approximate_presence_count</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<int> ApproximatePresenceCount { get; set; }

    /// <summary>
    ///     Approximate count of total members, returned from the <c>GET /invites/&lt;code&gt;</c> endpoint when
    ///     <c>with_counts</c> is <c>true</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>approximate_member_count</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<int> ApproximateMemberCount { get; set; }

    /// <summary>
    ///     The expiration date of this invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>expires_at</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public required DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>
    ///     Guild scheduled event data, only included if <c>guild_scheduled_event_id</c> contains a valid guild
    ///     scheduled event id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_scheduled_event</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<GuildScheduledEvent> GuildScheduledEvent { get; set; }

    /// <summary>
    ///     Guild invite flags for guild invites.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<GuildInviteFlags> Flags { get; set; }

    /// <summary>
    ///     The roles assigned to the user upon accepting the invite.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>roles</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-structure" />
    public Optional<List<PartialRole>> Roles { get; set; }
}