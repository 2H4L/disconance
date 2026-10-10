namespace Disconance.Models.StageInstances;

/// <summary>
///     Stage Instance data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
public class StageInstance
{
    /// <summary>
    ///     The id of this Stage instance.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The guild id of the associated Stage channel.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     The id of the associated Stage channel.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required Snowflake ChannelId { get; set; }

    /// <summary>
    ///     The topic of the Stage instance (1-120 characters).
    /// </summary>
    /// <remarks>Discord field: <c>topic</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required string Topic { get; set; }

    /// <summary>
    ///     The privacy level of the Stage instance.
    /// </summary>
    /// <remarks>Discord field: <c>privacy_level</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required StagePrivacyLevel PrivacyLevel { get; set; }

    /// <summary>
    ///     Whether or not Stage Discovery is disabled (deprecated).
    /// </summary>
    /// <remarks>Discord field: <c>discoverable_disabled</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required bool DiscoverableDisabled { get; set; }

    /// <summary>
    ///     The id of the scheduled event for this Stage instance.
    /// </summary>
    /// <remarks>Discord field: <c>guild_scheduled_event_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/stage-instance#stage-instance-object" />
    public required Snowflake? GuildScheduledEventId { get; set; }
}