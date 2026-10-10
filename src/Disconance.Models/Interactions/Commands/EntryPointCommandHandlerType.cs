namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Entry Point Command Handler Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public enum EntryPointCommandHandlerType
{
    /// <summary>
    ///     APP_HANDLER
    /// </summary>
    AppHandler = 1,

    /// <summary>
    ///     DISCORD_LAUNCH_ACTIVITY
    /// </summary>
    DiscordLaunchActivity = 2
}