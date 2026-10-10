namespace Disconance.Models.Guilds;

/// <summary>
///     Known Discord guild features. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-features" />
public static class GuildFeature
{
    /// <summary>
    ///     Guild has access to set an animated guild banner image.
    /// </summary>
    public const string AnimatedBanner = "ANIMATED_BANNER";

    /// <summary>
    ///     Guild has access to set an animated guild icon.
    /// </summary>
    public const string AnimatedIcon = "ANIMATED_ICON";

    /// <summary>
    ///     Guild is using the old permissions configuration behavior.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/change-log#upcoming-application-command-permission-changes" />
    public const string ApplicationCommandPermissionsV2 = "APPLICATION_COMMAND_PERMISSIONS_V2";

    /// <summary>
    ///     Guild has set up auto moderation rules.
    /// </summary>
    public const string AutoModeration = "AUTO_MODERATION";

    /// <summary>
    ///     Guild has access to set a guild banner image.
    /// </summary>
    public const string Banner = "BANNER";

    /// <summary>
    ///     Guild can enable welcome screen, Membership Screening, stage channels and discovery, and receives community
    ///     updates.
    /// </summary>
    public const string Community = "COMMUNITY";

    /// <summary>
    ///     Guild has enabled monetization.
    /// </summary>
    public const string CreatorMonetizableProvisional = "CREATOR_MONETIZABLE_PROVISIONAL";

    /// <summary>
    ///     Guild has enabled the role subscription promo page.
    /// </summary>
    public const string CreatorStorePage = "CREATOR_STORE_PAGE";

    /// <summary>
    ///     Guild has been set as a support server on the App Directory.
    /// </summary>
    public const string DeveloperSupportServer = "DEVELOPER_SUPPORT_SERVER";

    /// <summary>
    ///     Guild is able to be discovered in the directory.
    /// </summary>
    public const string Discoverable = "DISCOVERABLE";

    /// <summary>
    ///     Guild is able to set gradient colors to roles.
    /// </summary>
    public const string EnhancedRoleColors = "ENHANCED_ROLE_COLORS";

    /// <summary>
    ///     Guild is able to be featured in the directory.
    /// </summary>
    public const string Featurable = "FEATURABLE";

    /// <summary>
    ///     Guild has access to set guild tags.
    /// </summary>
    public const string GuildTags = "GUILD_TAGS";

    /// <summary>
    ///     Guild has access to guest invites.
    /// </summary>
    public const string GuestsEnabled = "GUESTS_ENABLED";

    /// <summary>
    ///     Guild has paused invites, preventing new users from joining.
    /// </summary>
    public const string InvitesDisabled = "INVITES_DISABLED";

    /// <summary>
    ///     Guild has access to set an invite splash background.
    /// </summary>
    public const string InviteSplash = "INVITE_SPLASH";

    /// <summary>
    ///     Guild has enabled Membership Screening.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#membership-screening-object" />
    public const string MemberVerificationGateEnabled = "MEMBER_VERIFICATION_GATE_ENABLED";

    /// <summary>
    ///     Guild has increased custom soundboard sound slots.
    /// </summary>
    public const string MoreSoundboard = "MORE_SOUNDBOARD";

    /// <summary>
    ///     Guild has increased custom sticker slots.
    /// </summary>
    public const string MoreStickers = "MORE_STICKERS";

    /// <summary>
    ///     Guild has access to create announcement channels.
    /// </summary>
    public const string News = "NEWS";

    /// <summary>
    ///     Guild is partnered.
    /// </summary>
    public const string Partnered = "PARTNERED";

    /// <summary>
    ///     Guild can be previewed before joining via Membership Screening or the directory.
    /// </summary>
    public const string PreviewEnabled = "PREVIEW_ENABLED";

    /// <summary>
    ///     Guild has enabled requiring admin to prune members.
    /// </summary>
    public const string PruneRequiresAdmin = "PRUNE_REQUIRES_ADMIN";

    /// <summary>
    ///     Guild has disabled alerts for join raids in the configured safety alerts channel.
    /// </summary>
    public const string RaidAlertsDisabled = "RAID_ALERTS_DISABLED";

    /// <summary>
    ///     Guild is able to set role icons.
    /// </summary>
    public const string RoleIcons = "ROLE_ICONS";

    /// <summary>
    ///     Guild has role subscriptions that can be purchased.
    /// </summary>
    public const string RoleSubscriptionsAvailableForPurchase = "ROLE_SUBSCRIPTIONS_AVAILABLE_FOR_PURCHASE";

    /// <summary>
    ///     Guild has enabled role subscriptions.
    /// </summary>
    public const string RoleSubscriptionsEnabled = "ROLE_SUBSCRIPTIONS_ENABLED";

    /// <summary>
    ///     Guild has created soundboard sounds.
    /// </summary>
    public const string Soundboard = "SOUNDBOARD";

    /// <summary>
    ///     Guild has enabled ticketed events.
    /// </summary>
    public const string TicketedEventsEnabled = "TICKETED_EVENTS_ENABLED";

    /// <summary>
    ///     Guild has access to set a vanity URL.
    /// </summary>
    public const string VanityUrl = "VANITY_URL";

    /// <summary>
    ///     Guild is verified.
    /// </summary>
    public const string Verified = "VERIFIED";

    /// <summary>
    ///     Guild has access to set 384kbps bitrate in voice (previously VIP voice servers).
    /// </summary>
    public const string VipRegions = "VIP_REGIONS";

    /// <summary>
    ///     Guild has enabled the welcome screen.
    /// </summary>
    public const string WelcomeScreenEnabled = "WELCOME_SCREEN_ENABLED";
}