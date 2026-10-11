using Disconance.Http.Requests.Interactions;
using Disconance.Http.Responses;
using Disconance.Http.Uploads;
using Disconance.Models;
using Disconance.Models.Interactions;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently builds CreateInteractionResponseRequest; mutable and not thread-safe.
/// </summary>
public sealed class CreateInteractionResponseRequestBuilder : IRequestBuilder<CreateInteractionResponseRequest>
{
    private readonly List<DiscordFile> _files = [];
    private readonly Snowflake _interactionId;
    private readonly string _interactionToken;
    private readonly InteractionResponseBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private bool? _WithResponse;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal CreateInteractionResponseRequestBuilder(Snowflake interactionId, string interactionToken,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _interactionId = interactionId;
        _interactionToken = interactionToken;
    }

    /// <inheritdoc />
    public CreateInteractionResponseRequest Build()
    {
        return new CreateInteractionResponseRequest(_interactionId, _interactionToken, _payload.Build())
        {
            AuditLogReason = _auditReason,
            Files = _files.ToArray(),
            WithResponse = _WithResponse
        };
    }

    /// <summary>
    ///     Composes a message callback.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithMessage(Action<InteractionMessageDataBuilder> configure)
    {
        _payload.WithMessage(configure);
        return this;
    }

    /// <summary>
    ///     Composes a modal callback.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithModal(Action<InteractionModalDataBuilder> configure)
    {
        _payload.WithModal(configure);
        return this;
    }

    /// <summary>
    ///     Composes a autocomplete callback.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithAutocomplete(
        Action<InteractionAutocompleteDataBuilder> configure)
    {
        _payload.WithAutocomplete(configure);
        return this;
    }

    /// <summary>
    ///     Creates a deferred message acknowledgement.
    /// </summary>
    public CreateInteractionResponseRequestBuilder Defer(bool ephemeral = false)
    {
        _payload.Defer(ephemeral);
        return this;
    }

    /// <summary>
    ///     Sets Type; explicit defaults remain present.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithType(InteractionCallbackType value)
    {
        _payload.WithType(value);
        return this;
    }

    /// <summary>
    ///     Sets Data; explicit defaults remain present.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithData(InteractionResponseData value)
    {
        _payload.WithData(value);
        return this;
    }

    /// <summary>
    ///     Omits Data.
    /// </summary>
    public CreateInteractionResponseRequestBuilder OmitData()
    {
        _payload.OmitData();
        return this;
    }

    /// <summary>
    ///     Adds a replayable upload. Supported only by Discord's message and callback endpoints.
    /// </summary>
    public CreateInteractionResponseRequestBuilder AddFile(DiscordFile file)
    {
        _files.Add(file);
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Sets query field WithResponse; null omits it.
    /// </summary>
    public CreateInteractionResponseRequestBuilder WithResponse(bool? value)
    {
        _WithResponse = value;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<InteractionCallbackResponse>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}