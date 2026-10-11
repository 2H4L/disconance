using Disconance.Models.Channels;

namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Widget data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
public class GuildWidget
{
    /// <summary>
    ///     Guild id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Guild name (2-100 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Instant invite for the guilds specified widget invite channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>instant_invite</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required string? InstantInvite { get; set; }

    /// <summary>
    ///     Voice and stage channels which are accessible by @everyone.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channels</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required List<PartialChannel> Channels { get; set; }

    /// <summary>
    ///     Special widget user objects that includes users presence (Limit 100).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>members</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required List<GuildWidgetUser> Members { get; set; }

    /// <summary>
    ///     Number of online members in this guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>presence_count</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-widget-object-guild-widget-structure" />
    public required int PresenceCount { get; set; }
}