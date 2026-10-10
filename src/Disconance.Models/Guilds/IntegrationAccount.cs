namespace Disconance.Models.Guilds;

/// <summary>
///     Integration Account data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#integration-account-object" />
public class IntegrationAccount
{
    /// <summary>
    ///     Id of the account.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-account-object" />
    public required string Id { get; set; }

    /// <summary>
    ///     Name of the account.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-account-object" />
    public required string Name { get; set; }
}