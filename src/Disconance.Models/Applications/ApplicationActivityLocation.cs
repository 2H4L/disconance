namespace Disconance.Models.Applications;

/// <summary>
///     Activity Location data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
public class ApplicationActivityLocation
{
    /// <summary>
    ///     Unique identifier for the location.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required string Id { get; set; }

    /// <summary>
    ///     Enum describing kind of location.
    /// </summary>
    /// <remarks>Discord field: <c>kind</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required string Kind { get; set; }

    /// <summary>
    ///     ID of the Channel.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object" />
    public required Snowflake ChannelId { get; set; }

    /// <summary>
    ///     ID of the Guild.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object" />
    public Optional<Snowflake?> GuildId { get; set; }
}