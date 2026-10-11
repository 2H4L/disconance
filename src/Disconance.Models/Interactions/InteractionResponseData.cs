namespace Disconance.Models.Interactions;

/// <summary>
///     Base for message, autocomplete, and modal response data.
/// </summary>
/// <remarks>
///     This is shared payload data. It does not perform an HTTP request or Gateway operation.
/// </remarks>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public abstract class InteractionResponseData;