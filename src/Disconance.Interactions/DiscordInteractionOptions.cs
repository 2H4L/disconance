namespace Disconance.Interactions;

/// <summary>
///     Configures the signed HTTP endpoint for one Discord application.
/// </summary>
public sealed class DiscordInteractionOptions
{
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