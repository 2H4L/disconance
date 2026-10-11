namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Profile Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#profile-data-object" />
public class ProfileData
{
    /// <summary>
    ///     Pre-configured game stat fields.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>primary</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#profile-data-object" />
    public Optional<PrimaryProfileData> Primary { get; set; }

    /// <summary>
    ///     Custom game stat fields.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>dynamic</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#profile-data-object" />
    public Optional<List<DynamicField>> Dynamic { get; set; }
}