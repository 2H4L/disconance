namespace Disconance.Models.AutoModeration;

/// <summary>
///     Auto Moderation Rule data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
public class AutoModerationRule
{
    /// <summary>
    ///     The id of this rule.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The id of the guild which this rule belongs to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     The rule name.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     The user which first created this rule.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>creator_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required Snowflake CreatorId { get; set; }

    /// <summary>
    ///     The rule event type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>event_type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required AutoModerationEventType EventType { get; set; }

    /// <summary>
    ///     The rule trigger type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>trigger_type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required AutoModerationTriggerType TriggerType { get; set; }

    /// <summary>
    ///     The rule trigger metadata.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>trigger_metadata</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required AutoModerationTriggerMetadata TriggerMetadata { get; set; }

    /// <summary>
    ///     The actions which will execute when the rule is triggered.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>actions</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required List<AutoModerationAction> Actions { get; set; }

    /// <summary>
    ///     Whether the rule is enabled.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>enabled</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required bool Enabled { get; set; }

    /// <summary>
    ///     The role ids that should not be affected by the rule (Maximum of 20).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>exempt_roles</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required List<Snowflake> ExemptRoles { get; set; }

    /// <summary>
    ///     The channel ids that should not be affected by the rule (Maximum of 50).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>exempt_channels</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public required List<Snowflake> ExemptChannels { get; set; }
}