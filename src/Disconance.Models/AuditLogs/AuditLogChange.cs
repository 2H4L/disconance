namespace Disconance.Models.AuditLogs;

/// <summary>
///     Audit Log Change data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-change-object" />
public class AuditLogChange
{
    /// <summary>
    ///     New value of the key.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>new_value</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-change-object" />
    public Optional<object?> NewValue { get; set; }

    /// <summary>
    ///     Old value of the key.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>old_value</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-change-object" />
    public Optional<object?> OldValue { get; set; }

    /// <summary>
    ///     Name of the changed entity, with a few exceptions.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>key</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-change-object" />
    public required string Key { get; set; }
}