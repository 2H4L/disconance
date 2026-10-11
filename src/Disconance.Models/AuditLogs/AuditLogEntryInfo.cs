namespace Disconance.Models.AuditLogs;

/// <summary>
///     Optional Audit Entry Info data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
public class AuditLogEntryInfo
{
    /// <summary>
    ///     ID of the app whose permissions were targeted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<Snowflake> ApplicationId { get; set; }

    /// <summary>
    ///     Name of the Auto Moderation rule that was triggered.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>auto_moderation_rule_name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> AutoModerationRuleName { get; set; }

    /// <summary>
    ///     Trigger type of the Auto Moderation rule that was triggered.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>auto_moderation_rule_trigger_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> AutoModerationRuleTriggerType { get; set; }

    /// <summary>
    ///     Channel in which the entities were targeted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<Snowflake> ChannelId { get; set; }

    /// <summary>
    ///     Number of entities that were targeted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>count</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> Count { get; set; }

    /// <summary>
    ///     Number of days after which inactive members were kicked.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>delete_member_days</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> DeleteMemberDays { get; set; }

    /// <summary>
    ///     ID of the overwritten entity.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     Number of members removed by the prune.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>members_removed</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> MembersRemoved { get; set; }

    /// <summary>
    ///     ID of the message that was targeted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>message_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<Snowflake> MessageId { get; set; }

    /// <summary>
    ///     Name of the role if type is <c>"0"</c> (not present if type is <c>"1"</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>role_name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> RoleName { get; set; }

    /// <summary>
    ///     Type of overwritten entity - role (<c>"0"</c>) or member (<c>"1"</c>).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> Type { get; set; }

    /// <summary>
    ///     The type of integration which performed the action.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>integration_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> IntegrationType { get; set; }

    /// <summary>
    ///     The new voice channel status.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>status</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> Status { get; set; }
}