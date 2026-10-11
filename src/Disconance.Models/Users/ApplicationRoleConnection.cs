namespace Disconance.Models.Users;

/// <summary>
///     Application Role Connection data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#application-role-connection-object" />
public class ApplicationRoleConnection
{
    /// <summary>
    ///     The vanity name of the platform a bot has connected (max 50 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>platform_name</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#application-role-connection-object" />
    public required string? PlatformName { get; set; }

    /// <summary>
    ///     Object mapping application role connection metadata keys to their <c>string</c> -ified value (max 100
    ///     characters) for the user on the platform a bot has connected.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>metadata</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#application-role-connection-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public required Dictionary<string, string> Metadata { get; set; }
}