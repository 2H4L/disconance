using Disconance.Http.Requests.Messages;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently builds GetChannelMessagesRequest; mutable and not thread-safe.
/// </summary>
public sealed class GetChannelMessagesRequestBuilder : IRequestBuilder<GetChannelMessagesRequest>
{
    private readonly Snowflake _channelId;
    private readonly IDiscordRequestSender _sender;
    private Snowflake? _after;
    private Snowflake? _around;
    private string? _auditReason;
    private Snowflake? _before;
    private int? _limit;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal GetChannelMessagesRequestBuilder(Snowflake channelId, IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _channelId = channelId;
    }

    /// <inheritdoc />
    public GetChannelMessagesRequest Build()
    {
        if (new[] { _before.HasValue, _after.HasValue, _around.HasValue }.Count(v => v) > 1)
        {
            throw new InvalidOperationException("Before, After and Around are mutually exclusive.");
        }

        return new GetChannelMessagesRequest(_channelId)
        {
            AuditLogReason = _auditReason,
            Before = _before,
            After = _after,
            Around = _around,
            Limit = _limit
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public GetChannelMessagesRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Sets query field Before; null omits it.
    /// </summary>
    public GetChannelMessagesRequestBuilder WithBefore(Snowflake? value)
    {
        _before = value;
        return this;
    }

    /// <summary>
    ///     Sets query field After; null omits it.
    /// </summary>
    public GetChannelMessagesRequestBuilder WithAfter(Snowflake? value)
    {
        _after = value;
        return this;
    }

    /// <summary>
    ///     Sets query field Around; null omits it.
    /// </summary>
    public GetChannelMessagesRequestBuilder WithAround(Snowflake? value)
    {
        _around = value;
        return this;
    }

    /// <summary>
    ///     Sets query field Limit; null omits it.
    /// </summary>
    public GetChannelMessagesRequestBuilder WithLimit(int? value)
    {
        _limit = value;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<List<Message>>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}