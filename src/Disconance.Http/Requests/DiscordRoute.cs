using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Disconance.Http.Requests;

/// <summary>
///     A relative route template with independently escaped parameters and a major-resource identity.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/rate-limits#rate-limits" />
public sealed partial class DiscordRoute
{
    /// <summary>
    ///     Creates a route. Keep tokens and IDs in parameters, never in template literals.
    /// </summary>
    public DiscordRoute(string template, IReadOnlyDictionary<string, string>? parameters = null,
        bool isInteraction = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(template);

        if (!TemplatePattern().IsMatch(template))
        {
            throw new ArgumentException("Expected a relative Discord route template.", nameof(template));
        }

        var segments = template.Split('/');

        var values = segments.Select(segment =>
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
            {
                if (parameters is null || !parameters.TryGetValue(segment[1..^1], out var value) ||
                    string.IsNullOrEmpty(value) || value is "." or "..")
                {
                    throw new ArgumentException("Missing or invalid route parameter.", nameof(parameters));
                }

                return Uri.EscapeDataString(value);
            }

            if (segment.Length == 0 || segment is "." or ".." || segment.Contains('{') || segment.Contains('}'))
            {
                throw new ArgumentException("Invalid route segment.", nameof(template));
            }

            return segment;
        }).ToArray();

        if (isInteraction && segments[0] is not ("interactions" or "webhooks"))
        {
            throw new ArgumentException("Only interaction routes can be exempt from the bot global limit.",
                nameof(isInteraction));
        }

        Template = template;
        Path = string.Join('/', values);
        IsInteraction = isInteraction || segments[0] == "interactions";
        var majorIndex = Array.FindIndex(segments, part => part is "channels" or "guilds" or "webhooks");

        var major = majorIndex >= 0 && majorIndex + 1 < values.Length
            ? segments[majorIndex] + "/" + values[majorIndex + 1]
            : "";

        if (segments[0] == "webhooks" && segments.Length > 2 && segments[2].Contains("token", StringComparison.Ordinal))
        {
            major += "/" + values[2];
        }

        MajorKey = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(major)));
        WebhookKey = segments[0] == "webhooks" ? MajorKey : null;
    }

    /// <summary>
    ///     The parameterized, credential-free endpoint template.
    /// </summary>
    public string Template { get; }

    /// <summary>
    ///     Whether this is an interaction callback or interaction webhook route.
    /// </summary>
    public bool IsInteraction { get; }

    internal string Path { get; }

    internal string MajorKey { get; }

    internal string? WebhookKey { get; }

    [GeneratedRegex(@"^[a-z][a-z0-9_@{}/.\-]*$")]
    private static partial Regex TemplatePattern();
}