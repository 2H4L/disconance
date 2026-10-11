using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds DeleteGlobalApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    DeleteGlobalApplicationCommandRequestBuilder : IRequestBuilder<DeleteGlobalApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _commandId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal DeleteGlobalApplicationCommandRequestBuilder(Snowflake applicationId, Snowflake commandId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _commandId = commandId;
    }

    /// <inheritdoc />
    public DeleteGlobalApplicationCommandRequest Build()
    {
        return new DeleteGlobalApplicationCommandRequest(_applicationId, _commandId)
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public DeleteGlobalApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
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