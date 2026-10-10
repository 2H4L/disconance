namespace Disconance.Models.Applications;

/// <summary>
///     Application Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#application-object-application-flags" />
[Flags]
public enum ApplicationFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Indicates if an app uses the Auto Moderation API.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation" />
    ApplicationAutoModerationRuleCreateBadge = 1UL << 6,

    /// <summary>
    ///     Intent required for bots in 100 or more servers to receive <c>presence_update</c> events.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#presence-update" />
    GatewayPresence = 1UL << 12,

    /// <summary>
    ///     Intent required for bots in under 100 servers to receive <c>presence_update</c> events, found on the Bot
    ///     page in your app's settings.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#presence-update" />
    GatewayPresenceLimited = 1UL << 13,

    /// <summary>
    ///     Intent required for bots in 100 or more servers to receive member-related events like
    ///     <c>guild_member_add</c> . See the list of member-related events under <c>GUILD_MEMBERS</c> .
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/events/gateway#list-of-intents" />
    GatewayGuildMembers = 1UL << 14,

    /// <summary>
    ///     Intent required for bots in under 100 servers to receive member-related events like <c>guild_member_add</c>
    ///     , found on the Bot page in your app's settings. See the list of member-related events under
    ///     <c>GUILD_MEMBERS</c> .
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/events/gateway#list-of-intents" />
    GatewayGuildMembersLimited = 1UL << 15,

    /// <summary>
    ///     Indicates unusual growth of an app that prevents verification.
    /// </summary>
    VerificationPendingGuildLimit = 1UL << 16,

    /// <summary>
    ///     Indicates if an app is embedded within the Discord client (currently unavailable publicly).
    /// </summary>
    Embedded = 1UL << 17,

    /// <summary>
    ///     Intent required for bots in 100 or more servers to receive message content.
    /// </summary>
    /// <seealso href="https://support-dev.discord.com/hc/en-us/articles/4404772028055" />
    GatewayMessageContent = 1UL << 18,

    /// <summary>
    ///     Intent required for bots in under 100 servers to receive message content, found on the Bot page in your
    ///     app's settings.
    /// </summary>
    /// <seealso href="https://support-dev.discord.com/hc/en-us/articles/4404772028055" />
    GatewayMessageContentLimited = 1UL << 19,

    /// <summary>
    ///     Indicates if an app has registered global application commands.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    ApplicationCommandBadge = 1UL << 23
}