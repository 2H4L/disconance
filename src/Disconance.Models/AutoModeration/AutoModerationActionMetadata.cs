namespace Disconance.Models.AutoModeration;

/// <summary>
///     Action Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
public class AutoModerationActionMetadata
{
    /// <summary>
    ///     Channel to which user content should be logged.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
    public Optional<Snowflake> ChannelId { get; set; }

    /// <summary>
    ///     Timeout duration in seconds.
    /// </summary>
    /// <remarks>Discord field: <c>duration_seconds</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
    public Optional<int> DurationSeconds { get; set; }

    /// <summary>
    ///     Additional explanation that will be shown to members whenever their message is blocked.
    /// </summary>
    /// <remarks>Discord field: <c>custom_message</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
    public Optional<string?> CustomMessage { get; set; }
}