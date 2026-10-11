using Disconance.Models.Users;

namespace Disconance.Http.Requests.Users;

/// <summary>
///     GET users/@me. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user" />
public sealed class GetCurrentUserRequest()
    : EndpointRequest<User>(HttpMethod.Get, new DiscordRoute("users/@me"));