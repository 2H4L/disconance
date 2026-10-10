namespace Disconance.Models.Permissions;

/// <summary>
///     Bitwise Permission Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#permissions-bitwise-permission-flags" />
[Flags]
public enum PermissionFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Allows creation of instant invites.
    /// </summary>
    CreateInstantInvite = 0x0000000000000001UL,

    /// <summary>
    ///     Allows kicking members.
    /// </summary>
    KickMembers = 0x0000000000000002UL,

    /// <summary>
    ///     Allows banning members.
    /// </summary>
    BanMembers = 0x0000000000000004UL,

    /// <summary>
    ///     Allows all permissions and bypasses channel permission overwrites.
    /// </summary>
    Administrator = 0x0000000000000008UL,

    /// <summary>
    ///     Allows management and editing of channels.
    /// </summary>
    ManageChannels = 0x0000000000000010UL,

    /// <summary>
    ///     Allows management and editing of the guild.
    /// </summary>
    ManageGuild = 0x0000000000000020UL,

    /// <summary>
    ///     Allows for adding new reactions to messages. This permission does not apply to reacting with an existing
    ///     reaction on a message.
    /// </summary>
    AddReactions = 0x0000000000000040UL,

    /// <summary>
    ///     Allows for viewing of audit logs.
    /// </summary>
    ViewAuditLog = 0x0000000000000080UL,

    /// <summary>
    ///     Allows for using priority speaker in a voice channel.
    /// </summary>
    PrioritySpeaker = 0x0000000000000100UL,

    /// <summary>
    ///     Allows the user to go live.
    /// </summary>
    Stream = 0x0000000000000200UL,

    /// <summary>
    ///     Allows guild members to view a channel, which includes reading messages in text channels and joining voice
    ///     channels.
    /// </summary>
    ViewChannel = 0x0000000000000400UL,

    /// <summary>
    ///     Allows for sending messages in a channel and creating threads in a forum (does not allow sending messages in
    ///     threads).
    /// </summary>
    SendMessages = 0x0000000000000800UL,

    /// <summary>
    ///     Allows for sending of <c>/tts</c> messages.
    /// </summary>
    SendTtsMessages = 0x0000000000001000UL,

    /// <summary>
    ///     Allows for deletion of other users messages.
    /// </summary>
    ManageMessages = 0x0000000000002000UL,

    /// <summary>
    ///     Links sent by users with this permission will be auto-embedded.
    /// </summary>
    EmbedLinks = 0x0000000000004000UL,

    /// <summary>
    ///     Allows for uploading images and files.
    /// </summary>
    AttachFiles = 0x0000000000008000UL,

    /// <summary>
    ///     Allows for reading of message history.
    /// </summary>
    ReadMessageHistory = 0x0000000000010000UL,

    /// <summary>
    ///     Allows for using the <c>@everyone</c> tag to notify all users in a channel, and the <c>@here</c> tag to
    ///     notify all online users in a channel.
    /// </summary>
    MentionEveryone = 0x0000000000020000UL,

    /// <summary>
    ///     Allows the usage of custom emojis from other servers.
    /// </summary>
    UseExternalEmojis = 0x0000000000040000UL,

    /// <summary>
    ///     Allows for viewing guild insights.
    /// </summary>
    ViewGuildInsights = 0x0000000000080000UL,

    /// <summary>
    ///     Allows for joining of a voice channel.
    /// </summary>
    Connect = 0x0000000000100000UL,

    /// <summary>
    ///     Allows for speaking in a voice channel.
    /// </summary>
    Speak = 0x0000000000200000UL,

    /// <summary>
    ///     Allows for muting members in a voice channel.
    /// </summary>
    MuteMembers = 0x0000000000400000UL,

    /// <summary>
    ///     Allows for deafening of members in a voice channel.
    /// </summary>
    DeafenMembers = 0x0000000000800000UL,

    /// <summary>
    ///     Allows for moving of members between voice channels.
    /// </summary>
    MoveMembers = 0x0000000001000000UL,

    /// <summary>
    ///     Allows for using voice-activity-detection in a voice channel.
    /// </summary>
    UseVad = 0x0000000002000000UL,

    /// <summary>
    ///     Allows for modification of own nickname.
    /// </summary>
    ChangeNickname = 0x0000000004000000UL,

    /// <summary>
    ///     Allows for modification of other users nicknames.
    /// </summary>
    ManageNicknames = 0x0000000008000000UL,

    /// <summary>
    ///     Allows management and editing of roles.
    /// </summary>
    ManageRoles = 0x0000000010000000UL,

    /// <summary>
    ///     Allows management and editing of webhooks.
    /// </summary>
    ManageWebhooks = 0x0000000020000000UL,

    /// <summary>
    ///     Allows for editing and deleting emojis, stickers, and soundboard sounds created by all users.
    /// </summary>
    ManageGuildExpressions = 0x0000000040000000UL,

    /// <summary>
    ///     Allows members to use application commands, including slash commands and context menu commands.
    /// </summary>
    UseApplicationCommands = 0x0000000080000000UL,

    /// <summary>
    ///     Allows for requesting to speak in stage channels.
    /// </summary>
    RequestToSpeak = 0x0000000100000000UL,

    /// <summary>
    ///     Allows for editing and deleting scheduled events created by all users.
    /// </summary>
    ManageEvents = 0x0000000200000000UL,

    /// <summary>
    ///     Allows for deleting and archiving threads, and viewing all private threads.
    /// </summary>
    ManageThreads = 0x0000000400000000UL,

    /// <summary>
    ///     Allows for creating public and announcement threads.
    /// </summary>
    CreatePublicThreads = 0x0000000800000000UL,

    /// <summary>
    ///     Allows for creating private threads.
    /// </summary>
    CreatePrivateThreads = 0x0000001000000000UL,

    /// <summary>
    ///     Allows the usage of custom stickers from other servers.
    /// </summary>
    UseExternalStickers = 0x0000002000000000UL,

    /// <summary>
    ///     Allows for sending messages in threads.
    /// </summary>
    SendMessagesInThreads = 0x0000004000000000UL,

    /// <summary>
    ///     Allows for using Activities (applications with the <c>EMBEDDED</c> flag).
    /// </summary>
    UseEmbeddedActivities = 0x0000008000000000UL,

    /// <summary>
    ///     Allows for timing out users to prevent them from sending or reacting to messages in chat and threads, and
    ///     from speaking in voice and stage channels.
    /// </summary>
    ModerateMembers = 0x0000010000000000UL,

    /// <summary>
    ///     Allows for viewing role subscription insights.
    /// </summary>
    ViewCreatorMonetizationAnalytics = 0x0000020000000000UL,

    /// <summary>
    ///     Allows for using soundboard in a voice channel.
    /// </summary>
    UseSoundboard = 0x0000040000000000UL,

    /// <summary>
    ///     Allows for creating emojis, stickers, and soundboard sounds, and editing and deleting those created by the
    ///     current user.
    /// </summary>
    CreateGuildExpressions = 0x0000080000000000UL,

    /// <summary>
    ///     Allows for creating scheduled events, and editing and deleting those created by the current user.
    /// </summary>
    CreateEvents = 0x0000100000000000UL,

    /// <summary>
    ///     Allows the usage of custom soundboard sounds from other servers.
    /// </summary>
    UseExternalSounds = 0x0000200000000000UL,

    /// <summary>
    ///     Allows sending voice messages.
    /// </summary>
    SendVoiceMessages = 0x0000400000000000UL,

    /// <summary>
    ///     Allows setting voice channel status.
    /// </summary>
    SetVoiceChannelStatus = 0x0001000000000000UL,

    /// <summary>
    ///     Allows sending polls.
    /// </summary>
    SendPolls = 0x0002000000000000UL,

    /// <summary>
    ///     Allows user-installed apps to send public responses. When disabled, users will still be allowed to use their
    ///     apps but the responses will be ephemeral. This only applies to apps not also installed to the server.
    /// </summary>
    UseExternalApps = 0x0004000000000000UL,

    /// <summary>
    ///     Allows pinning and unpinning messages.
    /// </summary>
    PinMessages = 0x0008000000000000UL,

    /// <summary>
    ///     Allows bypassing slowmode restrictions.
    /// </summary>
    BypassSlowmode = 0x0010000000000000UL
}