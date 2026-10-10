using Disconance.Models.Users;

namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
public class GuildScheduledEvent
{
    /// <summary>
    ///     The id of the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The guild id which the scheduled event belongs to.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     The channel id in which the scheduled event will be hosted, or <c>null</c> if scheduled entity type is
    ///     <c>EXTERNAL</c> .
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required Snowflake? ChannelId { get; set; }

    /// <summary>
    ///     The id of the user that created the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>creator_id</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public Optional<Snowflake?> CreatorId { get; set; }

    /// <summary>
    ///     The name of the scheduled event (1-100 characters).
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     The description of the scheduled event (1-1000 characters).
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public Optional<string?> Description { get; set; }

    /// <summary>
    ///     The time the scheduled event will start.
    /// </summary>
    /// <remarks>Discord field: <c>scheduled_start_time</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required DateTimeOffset ScheduledStartTime { get; set; }

    /// <summary>
    ///     The time the scheduled event will end, required if entity_type is <c>EXTERNAL</c> .
    /// </summary>
    /// <remarks>Discord field: <c>scheduled_end_time</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required DateTimeOffset? ScheduledEndTime { get; set; }

    /// <summary>
    ///     The privacy level of the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>privacy_level</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required GuildScheduledEventPrivacyLevel PrivacyLevel { get; set; }

    /// <summary>
    ///     The status of the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>status</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required GuildScheduledEventStatus Status { get; set; }

    /// <summary>
    ///     The type of the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>entity_type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required GuildScheduledEventEntityType EntityType { get; set; }

    /// <summary>
    ///     The id of an entity associated with a guild scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>entity_id</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required Snowflake? EntityId { get; set; }

    /// <summary>
    ///     Additional metadata for the guild scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>entity_metadata</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required GuildScheduledEventEntityMetadata? EntityMetadata { get; set; }

    /// <summary>
    ///     The user that created the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>creator</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public Optional<User> Creator { get; set; }

    /// <summary>
    ///     The number of users subscribed to the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>user_count</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public Optional<int> UserCount { get; set; }

    /// <summary>
    ///     The cover image hash of the scheduled event.
    /// </summary>
    /// <remarks>Discord field: <c>image</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Image { get; set; }

    /// <summary>
    ///     The definition for how often this event should recur.
    /// </summary>
    /// <remarks>Discord field: <c>recurrence_rule</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public required GuildScheduledEventRecurrenceRule? RecurrenceRule { get; set; }
}