namespace Disconance.Models.Channels;

/// <summary>
///     Channel Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-channel-types" />
public enum ChannelType
{
    /// <summary>
    ///     A text channel within a server.
    /// </summary>
    GuildText = 0,

    /// <summary>
    ///     A direct message between users.
    /// </summary>
    Dm = 1,

    /// <summary>
    ///     A voice channel within a server.
    /// </summary>
    GuildVoice = 2,

    /// <summary>
    ///     A direct message between multiple users.
    /// </summary>
    GroupDm = 3,

    /// <summary>
    ///     An organizational category that contains up to 50 channels.
    /// </summary>
    /// <seealso href="https://support.discord.com/hc/en-us/articles/115001580171-Channel-Categories-101" />
    GuildCategory = 4,

    /// <summary>
    ///     A channel that users can follow and crosspost into their own server (formerly news channels).
    /// </summary>
    /// <seealso href="https://support.discord.com/hc/en-us/articles/360032008192" />
    GuildAnnouncement = 5,

    /// <summary>
    ///     A temporary sub-channel within a GUILD_ANNOUNCEMENT channel.
    /// </summary>
    AnnouncementThread = 10,

    /// <summary>
    ///     A temporary sub-channel within a GUILD_TEXT or GUILD_FORUM channel.
    /// </summary>
    PublicThread = 11,

    /// <summary>
    ///     A temporary sub-channel within a GUILD_TEXT channel that is only viewable by those invited and those with
    ///     the MANAGE_THREADS permission.
    /// </summary>
    PrivateThread = 12,

    /// <summary>
    ///     A voice channel for hosting events with an audience.
    /// </summary>
    /// <seealso href="https://support.discord.com/hc/en-us/articles/1500005513722" />
    GuildStageVoice = 13,

    /// <summary>
    ///     The channel in a hub containing the listed servers.
    /// </summary>
    /// <seealso href="https://support.discord.com/hc/en-us/articles/4406046651927-Discord-Student-Hubs-FAQ" />
    GuildDirectory = 14,

    /// <summary>
    ///     Channel that can only contain threads.
    /// </summary>
    GuildForum = 15,

    /// <summary>
    ///     Channel that can only contain threads, similar to <c>GUILD_FORUM</c> channels.
    /// </summary>
    GuildMedia = 16
}