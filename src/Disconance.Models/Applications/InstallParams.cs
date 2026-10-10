using Disconance.Models.Permissions;

namespace Disconance.Models.Applications;

/// <summary>
///     Install Params data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#install-params-object" />
public class InstallParams
{
    /// <summary>
    ///     Scopes to add the application to the server with.
    /// </summary>
    /// <remarks>Discord field: <c>scopes</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#install-params-object" />
    /// <seealso href="https://docs.discord.com/developers/topics/oauth2#shared-resources-oauth2-scopes" />
    public required List<string> Scopes { get; set; }

    /// <summary>
    ///     Permissions to request for the bot role.
    /// </summary>
    /// <remarks>Discord field: <c>permissions</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#install-params-object" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions" />
    public required PermissionFlags Permissions { get; set; }
}