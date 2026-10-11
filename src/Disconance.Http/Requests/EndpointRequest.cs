namespace Disconance.Http.Requests;

/// <summary>
///     Base for explicit endpoint requests. Route metadata never becomes JSON.
/// </summary>
/// <typeparam name="T">
///     Response resource.
/// </typeparam>
public abstract class EndpointRequest<T>(HttpMethod method, DiscordRoute route) : IDiscordRequest<T>
{
    /// <inheritdoc />
    public HttpMethod Method { get; } = method;

    /// <inheritdoc />
    public DiscordRoute Route { get; } = route;

    /// <inheritdoc />
    public virtual object? Body => null;

    /// <inheritdoc />
    public virtual Func<HttpContent>? ContentFactory => null;

    /// <inheritdoc />
    public virtual IReadOnlyDictionary<string, string?>? Query => null;

    /// <inheritdoc />
    public string? AuditLogReason { get; init; }

    /// <inheritdoc />
    public virtual bool UseAuthorization => true;
}