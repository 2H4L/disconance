using Disconance.Http.Requests.Users;
using Disconance.Http.Responses;
using Disconance.Models.Users;

namespace Disconance.Http.Builders.Users;

/// <summary>
///     Fluently builds GetCurrentUserRequest; mutable and not thread-safe.
/// </summary>
public sealed class GetCurrentUserRequestBuilder : IRequestBuilder<GetCurrentUserRequest>
{
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal GetCurrentUserRequestBuilder(IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
    }

    /// <inheritdoc />
    public GetCurrentUserRequest Build()
    {
        return new GetCurrentUserRequest
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public GetCurrentUserRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<User>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}