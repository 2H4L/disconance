namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Application Identity data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/application-identity-profile#application-identity-object" />
public class ApplicationIdentity
{
    /// <summary>
    ///     The external account provider type.
    /// </summary>
    /// <remarks>Discord field: <c>provider_type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public required string ProviderType { get; set; }

    /// <summary>
    ///     Provider-specific identifier used to disambiguate identities; omitted when absent or empty.
    /// </summary>
    /// <remarks>Discord field: <c>provider_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<string> ProviderId { get; set; }

    /// <summary>
    ///     The user's ID in the external system.
    /// </summary>
    /// <remarks>Discord field: <c>provider_issued_user_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public required string ProviderIssuedUserId { get; set; }
}