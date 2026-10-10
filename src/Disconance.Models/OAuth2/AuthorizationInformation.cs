using Disconance.Models.Applications;
using Disconance.Models.Users;

namespace Disconance.Models.OAuth2;

/// <summary>
///     The application, scopes, expiration, and optional user associated with an authorization.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/oauth2#get-current-authorization-information" />
public class AuthorizationInformation
{
    /// <summary>
    ///     The authorized application.
    /// </summary>
    public required PartialApplication Application { get; set; }

    /// <summary>
    ///     The scopes granted to the application.
    /// </summary>
    public required List<string> Scopes { get; set; }

    /// <summary>
    ///     When the access token expires.
    /// </summary>
    public required DateTimeOffset Expires { get; set; }

    /// <summary>
    ///     The authorizing user, present when the identify scope was granted.
    /// </summary>
    public Optional<User> User { get; set; }
}