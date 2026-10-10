namespace Disconance.Models.Guilds;

/// <summary>
///     System Channel Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-system-channel-flags" />
[Flags]
public enum SystemChannelFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Suppress member join notifications.
    /// </summary>
    SuppressJoinNotifications = 1UL << 0,

    /// <summary>
    ///     Suppress server boost notifications.
    /// </summary>
    SuppressPremiumSubscriptions = 1UL << 1,

    /// <summary>
    ///     Suppress server setup tips.
    /// </summary>
    SuppressGuildReminderNotifications = 1UL << 2,

    /// <summary>
    ///     Hide member join sticker reply buttons.
    /// </summary>
    SuppressJoinNotificationReplies = 1UL << 3,

    /// <summary>
    ///     Suppress role subscription purchase and renewal notifications.
    /// </summary>
    SuppressRoleSubscriptionPurchaseNotifications = 1UL << 4,

    /// <summary>
    ///     Hide role subscription sticker reply buttons.
    /// </summary>
    SuppressRoleSubscriptionPurchaseNotificationReplies = 1UL << 5
}