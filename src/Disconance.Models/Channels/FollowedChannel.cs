namespace Disconance.Models.Channels;

/// <summary>
///     Followed Channel data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#followed-channel-object" />
public class FollowedChannel
{
    /// <summary>
    ///     Source channel id.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#followed-channel-object" />
    public required Snowflake ChannelId { get; set; }

    /// <summary>
    ///     Created target webhook id.
    /// </summary>
    /// <remarks>Discord field: <c>webhook_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#followed-channel-object" />
    public required Snowflake WebhookId { get; set; }
}