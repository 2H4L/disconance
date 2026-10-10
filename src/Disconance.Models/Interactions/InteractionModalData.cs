using Disconance.Models.Components;

namespace Disconance.Models.Interactions;

/// <summary>
///     Modal data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public class InteractionModalData : InteractionResponseData
{
    /// <summary>
    ///     Developer-defined identifier for the modal, 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Title of the popup modal, max 45 characters.
    /// </summary>
    /// <remarks>Discord field: <c>title</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required string Title { get; set; }

    /// <summary>
    ///     Between 1 and 5 (inclusive) components that make up the modal.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public required List<Component> Components { get; set; }
}