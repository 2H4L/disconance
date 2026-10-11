using Disconance.Http.Requests.Interactions;
using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently builds DeleteOriginalInteractionResponseRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    DeleteOriginalInteractionResponseRequestBuilder : IRequestBuilder<DeleteOriginalInteractionResponseRequest>
{
    private readonly Snowflake _applicationId;
    private readonly string _interactionToken;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal DeleteOriginalInteractionResponseRequestBuilder(Snowflake applicationId, string interactionToken,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _interactionToken = interactionToken;
    }

    /// <inheritdoc />
    public DeleteOriginalInteractionResponseRequest Build()
    {
        return new DeleteOriginalInteractionResponseRequest(_applicationId, _interactionToken)
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public DeleteOriginalInteractionResponseRequestBuilder WithAuditLogReason(string? reason)
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