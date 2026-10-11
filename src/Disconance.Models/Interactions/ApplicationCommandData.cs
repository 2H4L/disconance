using Disconance.Models.Interactions.Commands;

namespace Disconance.Models.Interactions;

/// <summary>
///     Application Command Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class ApplicationCommandData : InteractionData
{
    /// <summary>
    ///     <c>ID</c> of the invoked command.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     <c>name</c> of the invoked command.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     <c>type</c> of the invoked command.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required ApplicationCommandType Type { get; set; }

    /// <summary>
    ///     Converted users + roles + channels + attachments.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>resolved</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<ResolvedData> Resolved { get; set; }

    /// <summary>
    ///     Params + values from the user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>options</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<List<ApplicationCommandInteractionDataOption>> Options { get; set; }

    /// <summary>
    ///     ID of the guild the command is registered to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     ID of the user or message targeted by a user or message command.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>target_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#user-commands" />
    public Optional<Snowflake> TargetId { get; set; }
}