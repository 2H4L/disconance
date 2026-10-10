namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Context Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public enum InteractionContextType
{
    /// <summary>
    ///     Interaction can be used within servers.
    /// </summary>
    Guild = 0,

    /// <summary>
    ///     Interaction can be used within DMs with the app's bot user.
    /// </summary>
    BotDm = 1,

    /// <summary>
    ///     Interaction can be used within Group DMs and DMs other than the app's bot user.
    /// </summary>
    PrivateChannel = 2
}