using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds DeleteGuildApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class DeleteGuildApplicationCommandRequestBuilder : IRequestBuilder<DeleteGuildApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _commandId;
    private readonly Snowflake _guildId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal DeleteGuildApplicationCommandRequestBuilder(Snowflake applicationId, Snowflake guildId,
        Snowflake commandId, IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _guildId = guildId;
        _commandId = commandId;
    }

    /// <inheritdoc />
    public DeleteGuildApplicationCommandRequest Build()
    {
        return new DeleteGuildApplicationCommandRequest(_applicationId, _guildId, _commandId)
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public DeleteGuildApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<NoContent>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}