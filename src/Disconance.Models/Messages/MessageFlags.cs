namespace Disconance.Models.Messages;

/// <summary>
///     Message Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-flags" />
[Flags]
public enum MessageFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This message has been published to subscribed channels (via Channel Following).
    /// </summary>
    Crossposted = 1UL << 0,

    /// <summary>
    ///     This message originated from a message in another channel (via Channel Following).
    /// </summary>
    IsCrosspost = 1UL << 1,

    /// <summary>
    ///     Do not include any embeds when serializing this message.
    /// </summary>
    SuppressEmbeds = 1UL << 2,

    /// <summary>
    ///     The source message for this crosspost has been deleted (via Channel Following).
    /// </summary>
    SourceMessageDeleted = 1UL << 3,

    /// <summary>
    ///     This message came from the urgent message system.
    /// </summary>
    Urgent = 1UL << 4,

    /// <summary>
    ///     This message has an associated thread, with the same id as the message.
    /// </summary>
    HasThread = 1UL << 5,

    /// <summary>
    ///     This message is only visible to the user who invoked the Interaction.
    /// </summary>
    Ephemeral = 1UL << 6,

    /// <summary>
    ///     This message is an Interaction Response and the bot is "thinking".
    /// </summary>
    Loading = 1UL << 7,

    /// <summary>
    ///     This message failed to mention some roles and add their members to the thread.
    /// </summary>
    FailedToMentionSomeRolesInThread = 1UL << 8,

    /// <summary>
    ///     This message will not trigger push and desktop notifications.
    /// </summary>
    SuppressNotifications = 1UL << 12,

    /// <summary>
    ///     This message is a voice message.
    /// </summary>
    IsVoiceMessage = 1UL << 13,

    /// <summary>
    ///     This message has a snapshot (via Message Forwarding).
    /// </summary>
    HasSnapshot = 1UL << 14,

    /// <summary>
    ///     Allows you to create fully component -driven messages.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/components/overview" />
    IsComponentsV2 = 1UL << 15
}