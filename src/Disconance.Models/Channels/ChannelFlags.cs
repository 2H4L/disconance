namespace Disconance.Models.Channels;

/// <summary>
///     Channel Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-flags" />
[Flags]
public enum ChannelFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This thread is pinned to the top of its parent <c>GUILD_FORUM</c> or <c>GUILD_MEDIA</c> channel.
    /// </summary>
    Pinned = 1UL << 1,

    /// <summary>
    ///     Whether a tag is required to be specified when creating a thread in a <c>GUILD_FORUM</c> or a
    ///     <c>GUILD_MEDIA</c> channel. Tags are specified in the <c>applied_tags</c> field.
    /// </summary>
    RequireTag = 1UL << 4,

    /// <summary>
    ///     When set hides the embedded media download options. Available only for media channels.
    /// </summary>
    HideMediaDownloadOptions = 1UL << 15,

    /// <summary>
    ///     This channel's metadata has been obfuscated because the current user cannot view it. Only ever set on
    ///     channels received over the Gateway; the HTTP API never sets this flag. See Obfuscated Channels.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/events/gateway" />
    /// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-obfuscated-channels" />
    ChannelObfuscated = 1UL << 17,

    /// <summary>
    ///     This channel is a Spoiler Channel i.e. users must opt in to view its contents. Can be set on all textual
    ///     guild channels and voice channels (not <c>GUILD_STAGE</c> ). Can only be set if channel's <c>nsfw</c> is
    ///     false.
    /// </summary>
    IsSpoilerChannel = 1UL << 21
}