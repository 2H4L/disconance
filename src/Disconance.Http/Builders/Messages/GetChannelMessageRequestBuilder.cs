using Disconance.Http.Requests.Messages;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently builds GetChannelMessageRequest; mutable and not thread-safe.
/// </summary>
public sealed class GetChannelMessageRequestBuilder : IRequestBuilder<GetChannelMessageRequest>
{
    private readonly Snowflake _channelId;
    private readonly Snowflake _messageId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal GetChannelMessageRequestBuilder(Snowflake channelId, Snowflake messageId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _channelId = channelId;
        _messageId = messageId;
    }

    /// <inheritdoc />
    public GetChannelMessageRequest Build()
    {
        return new GetChannelMessageRequest(_channelId, _messageId)
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public GetChannelMessageRequestBuilder WithAuditLogReason(string? reason)
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