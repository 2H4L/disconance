namespace Disconance.Models.Guilds;

/// <summary>
///     Default Message Notification Level defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#guild-object-default-message-notification-level" />
public enum DefaultMessageNotificationLevel
{
    /// <summary>
    ///     Members will receive notifications for all messages by default.
    /// </summary>
    AllMessages = 0,

    /// <summary>
    ///     Members will receive notifications only for messages that @mention them by default.
    /// </summary>
    OnlyMentions = 1
}