using Disconance.Models.Interactions.Commands;

namespace Disconance.Models.Interactions;

/// <summary>
///     Application Command Interaction Data Option data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class ApplicationCommandInteractionDataOption
{
    /// <summary>
    ///     Name of the parameter.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     Value of application command option type.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required ApplicationCommandOptionType Type { get; set; }

    /// <summary>
    ///     Value of the option resulting from user input.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<CommandOptionValue> Value { get; set; }

    /// <summary>
    ///     Present if this option is a group or subcommand.
    /// </summary>
    /// <remarks>Discord field: <c>options</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<List<ApplicationCommandInteractionDataOption>> Options { get; set; }

    /// <summary>
    ///     <c>true</c> if this option is the currently focused option for autocomplete.
    /// </summary>
    /// <remarks>Discord field: <c>focused</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<bool> Focused { get; set; }
}