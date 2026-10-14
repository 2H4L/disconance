using Disconance.Models.Interactions;

namespace Disconance.Interactions.Commands;

/// <summary>
///     The interaction, command data, and options belonging to the selected command or subcommand.
/// </summary>
public sealed class CommandContext
{
    internal CommandContext(Interaction interaction, ApplicationCommandData data,
        IReadOnlyList<ApplicationCommandInteractionDataOption> options)
    {
        Interaction = interaction;
        Data = data;
        Options = options;
    }

    /// <summary>
    ///     The complete interaction, including user, guild, locale, and interaction token.
    /// </summary>
    public Interaction Interaction { get; }

    /// <summary>
    ///     The complete application command data, including resolved entities and context-menu targets.
    /// </summary>
    public ApplicationCommandData Data { get; }

    /// <summary>
    ///     The selected command's parameters, with group and subcommand wrappers removed.
    ///     Autocomplete requests may supply only a partial set of options.
    /// </summary>
    public IReadOnlyList<ApplicationCommandInteractionDataOption> Options { get; }
}