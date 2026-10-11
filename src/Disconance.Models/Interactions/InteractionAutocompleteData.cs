using Disconance.Models.Interactions.Commands;

namespace Disconance.Models.Interactions;

/// <summary>
///     Autocomplete data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public class InteractionAutocompleteData : InteractionResponseData
{
    /// <summary>
    ///     Autocomplete choices (max of 25 choices).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>choices</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required List<ApplicationCommandOptionChoice> Choices { get; set; }
}