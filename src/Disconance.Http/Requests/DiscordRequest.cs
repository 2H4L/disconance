namespace Disconance.Http.Requests;

/// <summary>
///     An escape hatch for explicitly described Discord endpoints.
/// </summary>
/// <typeparam name="TResponse">
///     The response resource.
/// </typeparam>
public sealed class DiscordRequest<TResponse>(HttpMethod method, DiscordRoute route) : IDiscordRequest<TResponse>
{
    /// <inheritdoc />
    public HttpMethod Method { get; } = method;

    /// <inheritdoc />
    public DiscordRoute Route { get; } = route;

    /// <inheritdoc />
    public object? Body { get; init; }

    /// <inheritdoc />
    public Func<HttpContent>? ContentFactory { get; init; }

    /// <inheritdoc />
    public IReadOnlyDictionary<string, string?>? Query { get; init; }

    /// <inheritdoc />
    public string? AuditLogReason { get; init; }

    /// <inheritdoc />
    public bool UseAuthorization { get; init; } = true;
}