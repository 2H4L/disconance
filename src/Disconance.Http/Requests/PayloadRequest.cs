using Disconance.Http.Uploads;

namespace Disconance.Http.Requests;

/// <summary>
///     An endpoint with an explicit typed payload and optional replayable uploads.
/// </summary>
/// <typeparam name="TResponse">
///     Response resource.
/// </typeparam>
/// <typeparam name="TPayload">
///     Writable endpoint payload.
/// </typeparam>
public abstract class PayloadRequest<TResponse, TPayload>(HttpMethod method, DiscordRoute route, TPayload payload)
    : EndpointRequest<TResponse>(method, route) where TPayload : class
{
    /// <summary>
    ///     The endpoint payload.
    /// </summary>
    public TPayload Payload { get; } = payload ?? throw new ArgumentNullException(nameof(payload));

    /// <summary>
    ///     Files whose streams are opened separately for each attempt.
    /// </summary>
    public IReadOnlyList<DiscordFile> Files { get; init; } = [];

    /// <inheritdoc />
    public override object? Body => Files.Count == 0 ? Payload : null;

    /// <inheritdoc />
    public override Func<HttpContent>? ContentFactory =>
        Files.Count == 0 ? null : DiscordMultipart.CreateFactory(Payload, Files);
}