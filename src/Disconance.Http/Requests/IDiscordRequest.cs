namespace Disconance.Http.Requests;

/// <summary>
///     An explicit Discord endpoint contract. Only Body is JSON serialized.
/// </summary>
/// <typeparam name="TResponse">
///     The response resource.
/// </typeparam>
public interface IDiscordRequest<TResponse>
{
    /// <summary>
    ///     The HTTP method.
    /// </summary>
    HttpMethod Method { get; }

    /// <summary>
    ///     The route and rate-limit identity.
    /// </summary>
    DiscordRoute Route { get; }

    /// <summary>
    ///     The JSON payload, mutually exclusive with ContentFactory.
    /// </summary>
    object? Body => null;

    /// <summary>
    ///     Creates fresh content and streams per attempt; the sender disposes them.
    /// </summary>
    Func<HttpContent>? ContentFactory => null;

    /// <summary>
    ///     Explicit query parameters; null values are omitted.
    /// </summary>
    IReadOnlyDictionary<string, string?>? Query => null;

    /// <summary>
    ///     An optional audit reason, encoded in X-Audit-Log-Reason.
    /// </summary>
    string? AuditLogReason => null;

    /// <summary>
    ///     Whether this endpoint uses the client's configured credential.
    /// </summary>
    bool UseAuthorization => true;
}