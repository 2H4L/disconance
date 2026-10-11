using Disconance.Models.Permissions;
using Disconance.Models.Users;

namespace Disconance.Models.Channels;

/// <summary>
///     A partial Channel resource. Each field may be absent; consult the source context for the supplied subset.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
public class PartialChannel
{
    /// <summary>
    ///     The id of this channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     The type of channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<ChannelType> Type { get; set; }

    /// <summary>
    ///     The id of the guild (may be missing for some channel objects received over gateway guild dispatches).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     Sorting position of the channel (channels with the same position are sorted by id).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>position</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> Position { get; set; }

    /// <summary>
    ///     Explicit permission overwrites for members and roles.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>permission_overwrites</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<List<Overwrite>> PermissionOverwrites { get; set; }

    /// <summary>
    ///     The name of the channel (1-100 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<string?> Name { get; set; }

    /// <summary>
    ///     The channel topic (0-4096 characters for <c>GUILD_FORUM</c> and <c>GUILD_MEDIA</c> channels, 0-1024
    ///     characters for all others).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>topic</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<string?> Topic { get; set; }

    /// <summary>
    ///     Whether the channel is age-restricted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>nsfw</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    /// <seealso href="https://support.discord.com/hc/en-us/articles/115000084051" />
    public Optional<bool> Nsfw { get; set; }

    /// <summary>
    ///     The id of the last message sent in this channel (or thread for <c>GUILD_FORUM</c> or <c>GUILD_MEDIA</c>
    ///     channels) (may not point to an existing or valid message or thread).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>last_message_id</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake?> LastMessageId { get; set; }

    /// <summary>
    ///     The bitrate (in bits per second) of the voice channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bitrate</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> Bitrate { get; set; }

    /// <summary>
    ///     The user limit of the voice channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user_limit</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> UserLimit { get; set; }

    /// <summary>
    ///     Amount of seconds a user has to wait before sending another message (0-21600); bots, as well as users with
    ///     the permission <c>BYPASS_SLOWMODE</c> , are unaffected.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>rate_limit_per_user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> RateLimitPerUser { get; set; }

    /// <summary>
    ///     The recipients of the DM.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>recipients</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<List<User>> Recipients { get; set; }

    /// <summary>
    ///     Icon hash of the group DM.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<string?> Icon { get; set; }

    /// <summary>
    ///     Id of the creator of the group DM or thread.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>owner_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake> OwnerId { get; set; }

    /// <summary>
    ///     Application id associated with the channel. for group DMs, this is the application that created the group.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application_id</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake?> ApplicationId { get; set; }

    /// <summary>
    ///     For group DM channels: whether the channel is managed by an application via the <c>gdm.join</c> OAuth2
    ///     scope.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>managed</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<bool> Managed { get; set; }

    /// <summary>
    ///     For guild channels: id of the parent category for a channel (each parent category can contain up to 50
    ///     channels), for threads: id of the text channel this thread was created.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>parent_id</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<Snowflake?> ParentId { get; set; }

    /// <summary>
    ///     When the last pinned message was pinned. This may be <c>null</c> in events such as <c>GUILD_CREATE</c> when
    ///     a message is not pinned.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>last_pin_timestamp</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<DateTimeOffset?> LastPinTimestamp { get; set; }

    /// <summary>
    ///     Voice region id for the voice channel, automatic when set to null.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>rtc_region</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-region-object" />
    public Optional<string?> RtcRegion { get; set; }

    /// <summary>
    ///     The camera video quality mode of the voice channel, 1 when not present.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>video_quality_mode</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<VideoQualityMode> VideoQualityMode { get; set; }

    /// <summary>
    ///     Number of messages (not including the initial message or deleted messages) in a thread.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>message_count</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> MessageCount { get; set; }

    /// <summary>
    ///     An approximate count of users in a thread, stops counting at 50.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member_count</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> MemberCount { get; set; }

    /// <summary>
    ///     Thread-specific fields not needed by other channels.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>thread_metadata</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<ThreadMetadata> ThreadMetadata { get; set; }

    /// <summary>
    ///     Thread member object for the current user, if they have joined the thread, only included on certain API
    ///     endpoints.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<ThreadMember> Member { get; set; }

    /// <summary>
    ///     Default duration, copied onto newly created threads, in minutes, threads will stop showing in the channel
    ///     list after the specified period of inactivity, can be set to: 60, 1440, 4320, 10080.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_auto_archive_duration</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> DefaultAutoArchiveDuration { get; set; }

    /// <summary>
    ///     Computed permissions for the invoking user in the channel, including overwrites, only included when part of
    ///     the <c>resolved</c> data received on an interaction. This does not include implicit permissions, which may
    ///     need to be checked separately.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>permissions</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#implicit-permissions" />
    public Optional<PermissionFlags> Permissions { get; set; }

    /// <summary>
    ///     Computed permissions for the bot user in the channel, including overwrites, only included when part of the
    ///     <c>resolved</c> data received on an interaction. This does not include implicit permissions, which may need
    ///     to be checked separately.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>app_permissions</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#implicit-permissions" />
    public Optional<PermissionFlags> AppPermissions { get; set; }

    /// <summary>
    ///     Channel flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<ChannelFlags> Flags { get; set; }

    /// <summary>
    ///     Number of messages ever sent in a thread, it's similar to <c>message_count</c> on message creation, but will
    ///     not decrement the number when a message is deleted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_message_sent</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> TotalMessageSent { get; set; }

    /// <summary>
    ///     The set of tags that can be used in a <c>GUILD_FORUM</c> or a <c>GUILD_MEDIA</c> channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>available_tags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<List<ForumTag>> AvailableTags { get; set; }

    /// <summary>
    ///     The IDs of the set of tags that have been applied to a thread in a <c>GUILD_FORUM</c> or a
    ///     <c>GUILD_MEDIA</c> channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>applied_tags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<List<Snowflake>> AppliedTags { get; set; }

    /// <summary>
    ///     The emoji to show in the add reaction button on a thread in a <c>GUILD_FORUM</c> or a <c>GUILD_MEDIA</c>
    ///     channel.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_reaction_emoji</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<DefaultReaction?> DefaultReactionEmoji { get; set; }

    /// <summary>
    ///     The initial <c>rate_limit_per_user</c> to set on newly created threads in a channel. this field is copied to
    ///     the thread at creation time and does not live update.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_thread_rate_limit_per_user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<int> DefaultThreadRateLimitPerUser { get; set; }

    /// <summary>
    ///     The default sort order type used to order posts in <c>GUILD_FORUM</c> and <c>GUILD_MEDIA</c> channels.
    ///     Defaults to <c>null</c> , which indicates a preferred sort order hasn't been set by a channel admin.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_sort_order</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<SortOrderType?> DefaultSortOrder { get; set; }

    /// <summary>
    ///     The default forum layout view used to display posts in <c>GUILD_FORUM</c> channels. Defaults to <c>0</c> ,
    ///     which indicates a layout view has not been set by a channel admin.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_forum_layout</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-structure" />
    public Optional<ForumLayoutType> DefaultForumLayout { get; set; }
}