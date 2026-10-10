namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Option Type defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public enum ApplicationCommandOptionType
{
    /// <summary>
    ///     SUB_COMMAND
    /// </summary>
    SubCommand = 1,

    /// <summary>
    ///     SUB_COMMAND_GROUP
    /// </summary>
    SubCommandGroup = 2,

    /// <summary>
    ///     STRING
    /// </summary>
    String = 3,

    /// <summary>
    ///     INTEGER
    /// </summary>
    Integer = 4,

    /// <summary>
    ///     BOOLEAN
    /// </summary>
    Boolean = 5,

    /// <summary>
    ///     USER
    /// </summary>
    User = 6,

    /// <summary>
    ///     CHANNEL
    /// </summary>
    Channel = 7,

    /// <summary>
    ///     ROLE
    /// </summary>
    Role = 8,

    /// <summary>
    ///     MENTIONABLE
    /// </summary>
    Mentionable = 9,

    /// <summary>
    ///     NUMBER
    /// </summary>
    Number = 10,

    /// <summary>
    ///     ATTACHMENT
    /// </summary>
    Attachment = 11
}