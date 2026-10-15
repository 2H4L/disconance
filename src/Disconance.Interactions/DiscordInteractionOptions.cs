using Disconance.Models;

namespace Disconance.Interactions;

/// <summary>
///     Configures one Discord application and its signed HTTP endpoint.
/// </summary>
public sealed class DiscordInteractionOptions
{
    /// <summary>
    ///     The application ID used by startup command registration when no explicit application ID is supplied.
    ///     May be omitted when receiving interactions without publishing commands or when targets use explicit IDs.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     The application's 32-byte Ed25519 public key, encoded as 64 hexadecimal characters.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/overview#setting-up-an-endpoint-validating-security-request-headers" />
    public string PublicKey { get; set; } = string.Empty;

    /// <summary>
    ///     Maximum request body size in bytes, including requests without Content-Length. Defaults to one MiB.
    /// </summary>
    public int MaxRequestBodySize { get; set; } = 1024 * 1024;
}
