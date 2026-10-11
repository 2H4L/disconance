using System.Net;

namespace Disconance.Http.Responses;

/// <summary>
///     A buffered response whose metadata remains available after HTTP resources are disposed.
/// </summary>
/// <typeparam name="T">
///     The response resource.
/// </typeparam>
public sealed record DiscordResponse<T>
{
    /// <summary>
    ///     The HTTP status.
    /// </summary>
    public required HttpStatusCode StatusCode { get; init; }

    /// <summary>
    ///     Whether the server supplied a nonempty response body.
    /// </summary>
    public required bool HasBody { get; init; }

    /// <summary>
    ///     The resource, or default when the endpoint returned no content.
    /// </summary>
    public T? Data { get; init; }

    /// <summary>
    ///     Response and content headers copied from the HTTP response.
    /// </summary>
    public IReadOnlyDictionary<string, string[]> Headers { get; init; } = new Dictionary<string, string[]>();
}