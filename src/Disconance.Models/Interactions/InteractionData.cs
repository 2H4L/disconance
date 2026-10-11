namespace Disconance.Models.Interactions;

/// <summary>
///     Base for command, component, and modal interaction data.
/// </summary>
/// <remarks>
///     The containing interaction's type selects the concrete data class.
/// </remarks>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public abstract class InteractionData;