using Disconance.Http.Requests.Interactions;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently builds GetFollowupMessageRequest; mutable and not thread-safe.
/// </summary>
public sealed class GetFollowupMessageRequestBuilder : IRequestBuilder<GetFollowupMessageRequest>
{
    private readonly Snowflake _applicationId;
    private readonly string _interactionToken;
    private readonly Snowflake _messageId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal GetFollowupMessageRequestBuilder(Snowflake applicationId, string interactionToken, Snowflake messageId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _interactionToken = interactionToken;
        _messageId = messageId;
    }

    /// <inheritdoc />
    public GetFollowupMessageRequest Build()
    {
        return new GetFollowupMessageRequest(_applicationId, _interactionToken, _messageId)
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public GetFollowupMessageRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<Message>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}