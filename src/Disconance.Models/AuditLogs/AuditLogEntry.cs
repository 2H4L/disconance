namespace Disconance.Models.AuditLogs;

/// <summary>
///     Audit Log Entry data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
public class AuditLogEntry
{
    /// <summary>
    ///     ID of the affected entity (webhook, user, role, etc.)
    /// </summary>
    /// <remarks>Discord field: <c>target_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public required string? TargetId { get; set; }

    /// <summary>
    ///     Changes made to the target_id.
    /// </summary>
    /// <remarks>Discord field: <c>changes</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<List<AuditLogChange>> Changes { get; set; }

    /// <summary>
    ///     User or app that made the changes.
    /// </summary>
    /// <remarks>Discord field: <c>user_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public required Snowflake? UserId { get; set; }

    /// <summary>
    ///     ID of the entry.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of action that occurred.
    /// </summary>
    /// <remarks>Discord field: <c>action_type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public required AuditLogEvent ActionType { get; set; }

    /// <summary>
    ///     Additional info for certain event types.
    /// </summary>
    /// <remarks>Discord field: <c>options</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<AuditLogEntryInfo> Options { get; set; }

    /// <summary>
    ///     Reason for the change (1-512 characters).
    /// </summary>
    /// <remarks>Discord field: <c>reason</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-entry-object" />
    public Optional<string> Reason { get; set; }
}