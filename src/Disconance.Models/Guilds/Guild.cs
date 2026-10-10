using Disconance.Models.Emojis;
using Disconance.Models.Permissions;
using Disconance.Models.Stickers;

namespace Disconance.Models.Guilds;

/// <summary>
///     Guild data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
public class Guild
{
    /// <summary>
    ///     Guild id.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Guild name (2-100 characters, excluding trailing and leading whitespace).
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Icon hash.
    /// </summary>
    /// <remarks>Discord field: <c>icon</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Icon { get; set; }

    /// <summary>
    ///     Icon hash, returned when in the template object.
    /// </summary>
    /// <remarks>Discord field: <c>icon_hash</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> IconHash { get; set; }

    /// <summary>
    ///     Splash hash.
    /// </summary>
    /// <remarks>Discord field: <c>splash</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Splash { get; set; }

    /// <summary>
    ///     Discovery splash hash; only present for guilds with the "DISCOVERABLE" feature.
    /// </summary>
    /// <remarks>Discord field: <c>discovery_splash</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? DiscoverySplash { get; set; }

    /// <summary>
    ///     True if the user is the owner of the guild.
    /// </summary>
    /// <remarks>Discord field: <c>owner</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user-guilds" />
    public Optional<bool> Owner { get; set; }

    /// <summary>
    ///     Id of owner.
    /// </summary>
    /// <remarks>Discord field: <c>owner_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake OwnerId { get; set; }

    /// <summary>
    ///     Total permissions for the user in the guild (excludes overwrites and implicit permissions).
    /// </summary>
    /// <remarks>Discord field: <c>permissions</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user-guilds" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#implicit-permissions" />
    public Optional<PermissionFlags> Permissions { get; set; }

    /// <summary>
    ///     Voice region id for the guild (deprecated).
    /// </summary>
    /// <remarks>Discord field: <c>region</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-region-object" />
    public Optional<string?> Region { get; set; }

    /// <summary>
    ///     Id of afk channel.
    /// </summary>
    /// <remarks>Discord field: <c>afk_channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? AfkChannelId { get; set; }

    /// <summary>
    ///     Afk timeout in seconds.
    /// </summary>
    /// <remarks>Discord field: <c>afk_timeout</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required int AfkTimeout { get; set; }

    /// <summary>
    ///     True if the server widget is enabled.
    /// </summary>
    /// <remarks>Discord field: <c>widget_enabled</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<bool> WidgetEnabled { get; set; }

    /// <summary>
    ///     The channel id that the widget will generate an invite to, or <c>null</c> if set to no invite.
    /// </summary>
    /// <remarks>Discord field: <c>widget_channel_id</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<Snowflake?> WidgetChannelId { get; set; }

    /// <summary>
    ///     Verification level required for the guild.
    /// </summary>
    /// <remarks>Discord field: <c>verification_level</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required VerificationLevel VerificationLevel { get; set; }

    /// <summary>
    ///     Default message notifications level.
    /// </summary>
    /// <remarks>Discord field: <c>default_message_notifications</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required DefaultMessageNotificationLevel DefaultMessageNotifications { get; set; }

    /// <summary>
    ///     Explicit content filter level.
    /// </summary>
    /// <remarks>Discord field: <c>explicit_content_filter</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required ExplicitContentFilterLevel ExplicitContentFilter { get; set; }

    /// <summary>
    ///     Roles in the guild.
    /// </summary>
    /// <remarks>Discord field: <c>roles</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required List<Role> Roles { get; set; }

    /// <summary>
    ///     Custom guild emojis.
    /// </summary>
    /// <remarks>Discord field: <c>emojis</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required List<Emoji> Emojis { get; set; }

    /// <summary>
    ///     Enabled guild features.
    /// </summary>
    /// <remarks>Discord field: <c>features</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required List<string> Features { get; set; }

    /// <summary>
    ///     Required MFA level for the guild.
    /// </summary>
    /// <remarks>Discord field: <c>mfa_level</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required MfaLevel MfaLevel { get; set; }

    /// <summary>
    ///     Application id of the guild creator if it is bot-created.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? ApplicationId { get; set; }

    /// <summary>
    ///     The id of the channel where guild notices such as welcome messages and boost events are posted.
    /// </summary>
    /// <remarks>Discord field: <c>system_channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? SystemChannelId { get; set; }

    /// <summary>
    ///     System channel flags.
    /// </summary>
    /// <remarks>Discord field: <c>system_channel_flags</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required SystemChannelFlags SystemChannelFlags { get; set; }

    /// <summary>
    ///     The id of the channel where Community guilds can display rules and/or guidelines.
    /// </summary>
    /// <remarks>Discord field: <c>rules_channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? RulesChannelId { get; set; }

    /// <summary>
    ///     The maximum number of presences for the guild (<c>null</c> is always returned, apart from the largest of
    ///     guilds).
    /// </summary>
    /// <remarks>Discord field: <c>max_presences</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int?> MaxPresences { get; set; }

    /// <summary>
    ///     The maximum number of members for the guild.
    /// </summary>
    /// <remarks>Discord field: <c>max_members</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> MaxMembers { get; set; }

    /// <summary>
    ///     The vanity url code for the guild.
    /// </summary>
    /// <remarks>Discord field: <c>vanity_url_code</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required string? VanityUrlCode { get; set; }

    /// <summary>
    ///     The description of a guild.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required string? Description { get; set; }

    /// <summary>
    ///     Banner hash.
    /// </summary>
    /// <remarks>Discord field: <c>banner</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Banner { get; set; }

    /// <summary>
    ///     Premium tier (Server Boost level).
    /// </summary>
    /// <remarks>Discord field: <c>premium_tier</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required PremiumTier PremiumTier { get; set; }

    /// <summary>
    ///     The number of boosts this guild currently has.
    /// </summary>
    /// <remarks>Discord field: <c>premium_subscription_count</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> PremiumSubscriptionCount { get; set; }

    /// <summary>
    ///     The preferred locale of a Community guild; used in server discovery and notices from Discord, and sent in
    ///     interactions; defaults to "en-US".
    /// </summary>
    /// <remarks>Discord field: <c>preferred_locale</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#locales" />
    public required string PreferredLocale { get; set; }

    /// <summary>
    ///     The id of the channel where admins and moderators of Community guilds receive notices from Discord.
    /// </summary>
    /// <remarks>Discord field: <c>public_updates_channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? PublicUpdatesChannelId { get; set; }

    /// <summary>
    ///     The maximum amount of users in a video channel.
    /// </summary>
    /// <remarks>Discord field: <c>max_video_channel_users</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> MaxVideoChannelUsers { get; set; }

    /// <summary>
    ///     The maximum amount of users in a stage video channel.
    /// </summary>
    /// <remarks>Discord field: <c>max_stage_video_channel_users</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> MaxStageVideoChannelUsers { get; set; }

    /// <summary>
    ///     Approximate number of members in this guild, returned from the <c>GET /guilds/&lt;id&gt;</c> and
    ///     <c>/users/@me/guilds</c> endpoints when <c>with_counts</c> is <c>true</c> .
    /// </summary>
    /// <remarks>Discord field: <c>approximate_member_count</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> ApproximateMemberCount { get; set; }

    /// <summary>
    ///     Approximate number of non-offline members in this guild, returned from the <c>GET /guilds/&lt;id&gt;</c> and
    ///     <c>/users/@me/guilds</c> endpoints when <c>with_counts</c> is <c>true</c> .
    /// </summary>
    /// <remarks>Discord field: <c>approximate_presence_count</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<int> ApproximatePresenceCount { get; set; }

    /// <summary>
    ///     The welcome screen of a Community guild, shown to new members, returned in an Invite's guild object.
    /// </summary>
    /// <remarks>Discord field: <c>welcome_screen</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object" />
    public Optional<WelcomeScreen> WelcomeScreen { get; set; }

    /// <summary>
    ///     Guild age-restriction level.
    /// </summary>
    /// <remarks>Discord field: <c>nsfw_level</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required GuildNsfwLevel NsfwLevel { get; set; }

    /// <summary>
    ///     Custom guild stickers.
    /// </summary>
    /// <remarks>Discord field: <c>stickers</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public Optional<List<Sticker>> Stickers { get; set; }

    /// <summary>
    ///     Whether the guild has the boost progress bar enabled.
    /// </summary>
    /// <remarks>Discord field: <c>premium_progress_bar_enabled</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required bool PremiumProgressBarEnabled { get; set; }

    /// <summary>
    ///     The id of the channel where admins and moderators of Community guilds receive safety alerts from Discord.
    /// </summary>
    /// <remarks>Discord field: <c>safety_alerts_channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required Snowflake? SafetyAlertsChannelId { get; set; }

    /// <summary>
    ///     The incidents data for this guild.
    /// </summary>
    /// <remarks>Discord field: <c>incidents_data</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-guild-structure" />
    public required IncidentsData? IncidentsData { get; set; }
}