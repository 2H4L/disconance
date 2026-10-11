namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Application Identity Profile data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
public class ApplicationIdentityProfile
{
    /// <summary>
    ///     The user's username in the external system.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>username</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public required string? Username { get; set; }

    /// <summary>
    ///     Arbitrary game-defined data; not consumed by Discord, stored for the application's own use.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>metadata</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public required Dictionary<string, object?>? Metadata { get; set; }

    /// <summary>
    ///     The profile data containing game stats.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>data</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public required ProfileData? Data { get; set; }
}