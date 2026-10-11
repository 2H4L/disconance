using System.Text.Json;
using Disconance.Models.Serialization;

namespace Disconance.Http;

/// <summary>
///     Configuration for one long-lived credential and its local rate-limit state.
/// </summary>
public sealed class DiscordHttpOptions
{
    /// <summary>
    ///     The token without a scheme; omit for interaction-token-only clients.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    ///     Bot or Bearer.
    /// </summary>
    public string AuthenticationScheme { get; set; } = "Bot";

    /// <summary>
    ///     Per-attempt timeout. Use cancellation to bound the whole logical operation.
    /// </summary>
    public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(30);

    /// <summary>
    ///     Maximum additional attempts after 429 responses.
    /// </summary>
    public int MaxRateLimitRetries { get; set; } = 5;

    /// <summary>
    ///     Proactive requests per second for non-interaction routes.
    /// </summary>
    public int GlobalRequestsPerSecond { get; set; } = 50;

    /// <summary>
    ///     Stops local sends before reaching Discord's invalid-request threshold.
    /// </summary>
    public int InvalidRequestThreshold { get; set; } = 9000;

    /// <summary>
    ///     The shared JSON configuration; copied when the client is constructed.
    /// </summary>
    public JsonSerializerOptions SerializerOptions { get; set; } = DiscordJson.CreateOptions();
}