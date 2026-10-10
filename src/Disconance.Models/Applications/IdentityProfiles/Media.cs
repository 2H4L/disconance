namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Media data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#media-object" />
public class Media
{
    /// <summary>
    ///     URL of the media asset.
    /// </summary>
    /// <remarks>Discord field: <c>url</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#media-object" />
    public required string Url { get; set; }
}