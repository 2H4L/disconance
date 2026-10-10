namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Type defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public enum InteractionType
{
    /// <summary>
    ///     PING
    /// </summary>
    Ping = 1,

    /// <summary>
    ///     APPLICATION_COMMAND
    /// </summary>
    ApplicationCommand = 2,

    /// <summary>
    ///     MESSAGE_COMPONENT
    /// </summary>
    MessageComponent = 3,

    /// <summary>
    ///     APPLICATION_COMMAND_AUTOCOMPLETE
    /// </summary>
    ApplicationCommandAutocomplete = 4,

    /// <summary>
    ///     MODAL_SUBMIT
    /// </summary>
    ModalSubmit = 5
}