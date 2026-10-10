namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public enum ApplicationCommandType
{
    /// <summary>
    ///     Slash commands; a text-based command that shows up when a user types <c>/</c> .
    /// </summary>
    ChatInput = 1,

    /// <summary>
    ///     A UI-based command that shows up when you right click or tap on a user.
    /// </summary>
    User = 2,

    /// <summary>
    ///     A UI-based command that shows up when you right click or tap on a message.
    /// </summary>
    Message = 3,

    /// <summary>
    ///     A UI-based command that represents the primary way to invoke an app's Activity.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/activities/overview" />
    PrimaryEntryPoint = 4
}