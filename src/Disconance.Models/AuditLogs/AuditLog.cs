using Disconance.Models.AutoModeration;
using Disconance.Models.Channels;
using Disconance.Models.Guilds;
using Disconance.Models.Guilds.ScheduledEvents;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Users;
using Disconance.Models.Webhooks;

namespace Disconance.Models.AuditLogs;

/// <summary>
///     Audit Log data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
public class AuditLog
{
    /// <summary>
    ///     List of application commands referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>application_commands</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<ApplicationCommand> ApplicationCommands { get; set; }

    /// <summary>
    ///     List of audit log entries, sorted from most to least recent.
    /// </summary>
    /// <remarks>Discord field: <c>audit_log_entries</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<AuditLogEntry> AuditLogEntries { get; set; }

    /// <summary>
    ///     List of auto moderation rules referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>auto_moderation_rules</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<AutoModerationRule> AutoModerationRules { get; set; }

    /// <summary>
    ///     List of guild scheduled events referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>guild_scheduled_events</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<GuildScheduledEvent> GuildScheduledEvents { get; set; }

    /// <summary>
    ///     List of partial integration objects.
    /// </summary>
    /// <remarks>Discord field: <c>integrations</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<PartialIntegration> Integrations { get; set; }

    /// <summary>
    ///     List of threads referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>threads</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<Channel> Threads { get; set; }

    /// <summary>
    ///     List of users referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>users</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<User> Users { get; set; }

    /// <summary>
    ///     List of webhooks referenced in the audit log.
    /// </summary>
    /// <remarks>Discord field: <c>webhooks</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/audit-log#audit-log-object-audit-log-structure" />
    public required List<Webhook> Webhooks { get; set; }
}