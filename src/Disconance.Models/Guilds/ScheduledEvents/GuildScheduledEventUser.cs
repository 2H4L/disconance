using Disconance.Models.Users;

namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event User data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-user-object" />
public class GuildScheduledEventUser
{
    /// <summary>
    ///     The scheduled event id which the user subscribed to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_scheduled_event_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required Snowflake GuildScheduledEventId { get; set; }

    /// <summary>
    ///     User which subscribed to an event.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public required User User { get; set; }

    /// <summary>
    ///     Guild member data for this user for the guild which this event belongs to, if any.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event" />
    public Optional<GuildMember> Member { get; set; }
}