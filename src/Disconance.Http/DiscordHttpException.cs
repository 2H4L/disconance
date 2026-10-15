using System.Net;
using System.Text.Json;

namespace Disconance.Http;

/// <summary>
///     A Discord API failure. Raw response data can contain sensitive application content.
/// </summary>
public sealed class DiscordHttpException : HttpRequestException
{
    /// <summary>
    ///     Creates an API error from the received status and body.
    /// </summary>
    public DiscordHttpException(HttpStatusCode status, string responseBody) : base(
        $"Discord API returned HTTP {(int) status}.", null, status)
    {
        ResponseBody = responseBody;

        try
        {
            using var document = JsonDocument.Parse(responseBody);
            var root = document.RootElement;

            if (root.ValueKind != JsonValueKind.Object)
            {
                return;
            }

            if (root.TryGetProperty("code", out var code) && code.ValueKind == JsonValueKind.Number &&
                code.TryGetInt64(out var number))
            {
                Code = number;
            }

            if (root.TryGetProperty("message", out var message) && message.ValueKind == JsonValueKind.String)
            {
                DiscordMessage = message.GetString();
            }

            if (root.TryGetProperty("errors", out var errors))
            {
                Errors = errors.Clone();
            }
        }
        catch (JsonException)
        {
        }
    }

    /// <summary>
    ///     Discord's numeric error code, including unknown codes.
    /// </summary>
    public long? Code { get; }

    /// <summary>
    ///     Discord's error description; may include user-supplied data.
    /// </summary>
    public string? DiscordMessage { get; }

    /// <summary>
    ///     The open nested validation-error tree.
    /// </summary>
    public JsonElement? Errors { get; }

    /// <summary>
    ///     The raw response body. Do not log automatically.
    /// </summary>
    public string ResponseBody { get; }
}