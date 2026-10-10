namespace Disconance.Models.Applications;

/// <summary>
///     Application Integration Type Configuration data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#application-object" />
public class ApplicationIntegrationTypeConfiguration
{
    /// <summary>
    ///     Install params for each installation context's default in-app authorization link.
    /// </summary>
    /// <remarks>Discord field: <c>oauth2_install_params</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#application-object" />
    public Optional<InstallParams> Oauth2InstallParams { get; set; }
}