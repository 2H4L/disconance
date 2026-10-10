namespace Disconance.Models.Messages;

/// <summary>
///     Message Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-types" />
public enum MessageType
{
    /// <summary>
    ///     DEFAULT
    /// </summary>
    Default = 0,

    /// <summary>
    ///     RECIPIENT_ADD
    /// </summary>
    RecipientAdd = 1,

    /// <summary>
    ///     RECIPIENT_REMOVE
    /// </summary>
    RecipientRemove = 2,

    /// <summary>
    ///     CALL
    /// </summary>
    Call = 3,

    /// <summary>
    ///     CHANNEL_NAME_CHANGE
    /// </summary>
    ChannelNameChange = 4,

    /// <summary>
    ///     CHANNEL_ICON_CHANGE
    /// </summary>
    ChannelIconChange = 5,

    /// <summary>
    ///     CHANNEL_PINNED_MESSAGE
    /// </summary>
    ChannelPinnedMessage = 6,

    /// <summary>
    ///     USER_JOIN
    /// </summary>
    UserJoin = 7,

    /// <summary>
    ///     GUILD_BOOST
    /// </summary>
    GuildBoost = 8,

    /// <summary>
    ///     GUILD_BOOST_TIER_1
    /// </summary>
    GuildBoostTier1 = 9,

    /// <summary>
    ///     GUILD_BOOST_TIER_2
    /// </summary>
    GuildBoostTier2 = 10,

    /// <summary>
    ///     GUILD_BOOST_TIER_3
    /// </summary>
    GuildBoostTier3 = 11,

    /// <summary>
    ///     CHANNEL_FOLLOW_ADD
    /// </summary>
    ChannelFollowAdd = 12,

    /// <summary>
    ///     GUILD_DISCOVERY_DISQUALIFIED
    /// </summary>
    GuildDiscoveryDisqualified = 14,

    /// <summary>
    ///     GUILD_DISCOVERY_REQUALIFIED
    /// </summary>
    GuildDiscoveryRequalified = 15,

    /// <summary>
    ///     GUILD_DISCOVERY_GRACE_PERIOD_INITIAL_WARNING
    /// </summary>
    GuildDiscoveryGracePeriodInitialWarning = 16,

    /// <summary>
    ///     GUILD_DISCOVERY_GRACE_PERIOD_FINAL_WARNING
    /// </summary>
    GuildDiscoveryGracePeriodFinalWarning = 17,

    /// <summary>
    ///     THREAD_CREATED
    /// </summary>
    ThreadCreated = 18,

    /// <summary>
    ///     REPLY
    /// </summary>
    Reply = 19,

    /// <summary>
    ///     CHAT_INPUT_COMMAND
    /// </summary>
    ChatInputCommand = 20,

    /// <summary>
    ///     THREAD_STARTER_MESSAGE
    /// </summary>
    ThreadStarterMessage = 21,

    /// <summary>
    ///     GUILD_INVITE_REMINDER
    /// </summary>
    GuildInviteReminder = 22,

    /// <summary>
    ///     CONTEXT_MENU_COMMAND
    /// </summary>
    ContextMenuCommand = 23,

    /// <summary>
    ///     AUTO_MODERATION_ACTION
    /// </summary>
    AutoModerationAction = 24,

    /// <summary>
    ///     ROLE_SUBSCRIPTION_PURCHASE
    /// </summary>
    RoleSubscriptionPurchase = 25,

    /// <summary>
    ///     INTERACTION_PREMIUM_UPSELL
    /// </summary>
    InteractionPremiumUpsell = 26,

    /// <summary>
    ///     STAGE_START
    /// </summary>
    StageStart = 27,

    /// <summary>
    ///     STAGE_END
    /// </summary>
    StageEnd = 28,

    /// <summary>
    ///     STAGE_SPEAKER
    /// </summary>
    StageSpeaker = 29,

    /// <summary>
    ///     STAGE_TOPIC
    /// </summary>
    StageTopic = 31,

    /// <summary>
    ///     GUILD_APPLICATION_PREMIUM_SUBSCRIPTION
    /// </summary>
    GuildApplicationPremiumSubscription = 32,

    /// <summary>
    ///     GUILD_INCIDENT_ALERT_MODE_ENABLED
    /// </summary>
    GuildIncidentAlertModeEnabled = 36,

    /// <summary>
    ///     GUILD_INCIDENT_ALERT_MODE_DISABLED
    /// </summary>
    GuildIncidentAlertModeDisabled = 37,

    /// <summary>
    ///     GUILD_INCIDENT_REPORT_RAID
    /// </summary>
    GuildIncidentReportRaid = 38,

    /// <summary>
    ///     GUILD_INCIDENT_REPORT_FALSE_ALARM
    /// </summary>
    GuildIncidentReportFalseAlarm = 39,

    /// <summary>
    ///     PURCHASE_NOTIFICATION
    /// </summary>
    PurchaseNotification = 44,

    /// <summary>
    ///     POLL_RESULT
    /// </summary>
    PollResult = 46
}