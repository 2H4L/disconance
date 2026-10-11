using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds GetGlobalApplicationCommandsRequest; mutable and not thread-safe.
/// </summary>
public sealed class GetGlobalApplicationCommandsRequestBuilder : IRequestBuilder<GetGlobalApplicationCommandsRequest>
{
    private readonly Snowflake _applicationId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;
    private bool? _withLocalizations;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal GetGlobalApplicationCommandsRequestBuilder(Snowflake applicationId, IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
    }

    /// <inheritdoc />
    public GetGlobalApplicationCommandsRequest Build()
    {
        return new GetGlobalApplicationCommandsRequest(_applicationId)
        {
            AuditLogReason = _auditReason,
            WithLocalizations = _withLocalizations
        };
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public GetGlobalApplicationCommandsRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Sets query field WithLocalizations; null omits it.
    /// </summary>
    public GetGlobalApplicationCommandsRequestBuilder WithLocalizations(bool? value)
    {
        _withLocalizations = value;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<List<ApplicationCommand>>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}