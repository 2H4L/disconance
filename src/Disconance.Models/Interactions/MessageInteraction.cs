using Disconance.Models.Guilds;
using Disconance.Models.Users;

namespace Disconance.Models.Interactions;

/// <summary>
///     Message Interaction data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#message-interaction-object" />
public class MessageInteraction
{
    /// <summary>
    ///     ID of the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required InteractionType Type { get; set; }

    /// <summary>
    ///     Name of the application command, including subcommands and subcommand groups.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     User who invoked the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required User User { get; set; }

    /// <summary>
    ///     Member who invoked the interaction in the guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<PartialGuildMember> Member { get; set; }
}