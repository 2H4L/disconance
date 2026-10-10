namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Callback Type defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-response-object" />
public enum InteractionCallbackType
{
    /// <summary>
    ///     ACK a <c>Ping</c> .
    /// </summary>
    Pong = 1,

    /// <summary>
    ///     Respond to an interaction with a message.
    /// </summary>
    ChannelMessageWithSource = 4,

    /// <summary>
    ///     ACK an interaction and edit a response later, the user sees a loading state.
    /// </summary>
    DeferredChannelMessageWithSource = 5,

    /// <summary>
    ///     For components, ACK an interaction and edit the original message later; the user does not see a loading
    ///     state.
    /// </summary>
    DeferredUpdateMessage = 6,

    /// <summary>
    ///     For components, edit the message the component was attached to.
    /// </summary>
    UpdateMessage = 7,

    /// <summary>
    ///     Respond to an autocomplete interaction with suggested choices.
    /// </summary>
    ApplicationCommandAutocompleteResult = 8,

    /// <summary>
    ///     Respond to an interaction with a popup modal.
    /// </summary>
    Modal = 9,

    /// <summary>
    ///     Deprecated; respond to an interaction with an upgrade button, only available for apps with monetization
    ///     enabled.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/monetization/overview" />
    PremiumRequired = 10,

    /// <summary>
    ///     Launch the Activity associated with the app. Only available for apps with Activities enabled.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/activities/overview" />
    LaunchActivity = 12
}