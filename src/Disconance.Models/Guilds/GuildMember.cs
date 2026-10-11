using Disconance.Models.Permissions;
using Disconance.Models.Users;

namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Member data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
public class GuildMember
{
    /// <summary>
    ///     The user this guild member represents.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     This user's guild nickname.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>nick</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<string?> Nick { get; set; }

    /// <summary>
    ///     The member's guild avatar hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>avatar</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Avatar { get; set; }

    /// <summary>
    ///     The member's guild banner hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>banner</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Banner { get; set; }

    /// <summary>
    ///     Array of role object ids.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>roles</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object" />
    public required List<Snowflake> Roles { get; set; }

    /// <summary>
    ///     When the user joined the guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>joined_at</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public required DateTimeOffset? JoinedAt { get; set; }

    /// <summary>
    ///     When the user started boosting the guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>premium_since</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    /// <seealso href="https://support.discord.com/hc/en-us/articles/360028038352-Server-Boosting-" />
    public Optional<DateTimeOffset?> PremiumSince { get; set; }

    /// <summary>
    ///     Whether the user is deafened in voice channels.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>deaf</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public required bool Deaf { get; set; }

    /// <summary>
    ///     Whether the user is muted in voice channels.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>mute</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public required bool Mute { get; set; }

    /// <summary>
    ///     Guild member flags represented as a bit set, defaults to <c>0</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public required GuildMemberFlags Flags { get; set; }

    /// <summary>
    ///     Whether the user has not yet passed the guild's Membership Screening requirements.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>pending</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<bool> Pending { get; set; }

    /// <summary>
    ///     Total permissions of the member in the channel, including overwrites, returned when in the interaction
    ///     object.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>permissions</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<PermissionFlags> Permissions { get; set; }

    /// <summary>
    ///     When the user's timeout will expire and the user will be able to communicate in the guild again, null or a
    ///     time in the past if the user is not timed out.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>communication_disabled_until</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    /// <seealso href="https://support.discord.com/hc/en-us/articles/4413305239191-Time-Out-FAQ" />
    public Optional<DateTimeOffset?> CommunicationDisabledUntil { get; set; }

    /// <summary>
    ///     Data for the member's guild avatar decoration.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>avatar_decoration_data</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<AvatarDecorationData?> AvatarDecorationData { get; set; }

    /// <summary>
    ///     Data for the member's collectibles.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>collectibles</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-structure" />
    public Optional<Collectible?> Collectibles { get; set; }
}