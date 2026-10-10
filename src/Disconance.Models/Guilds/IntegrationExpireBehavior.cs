namespace Disconance.Models.Guilds;

/// <summary>
///     Integration Expire Behaviors defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#integration-object-integration-expire-behaviors" />
public enum IntegrationExpireBehavior
{
    /// <summary>
    ///     Remove role
    /// </summary>
    RemoveRole = 0,

    /// <summary>
    ///     Kick
    /// </summary>
    Kick = 1
}