namespace Disconance.Models.Activities;

/// <summary>
///     Activity Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-flags" />
[Flags]
public enum ActivityFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     INSTANCE
    /// </summary>
    Instance = 1UL << 0,

    /// <summary>
    ///     JOIN
    /// </summary>
    Join = 1UL << 1,

    /// <summary>
    ///     SPECTATE
    /// </summary>
    Spectate = 1UL << 2,

    /// <summary>
    ///     JOIN_REQUEST
    /// </summary>
    JoinRequest = 1UL << 3,

    /// <summary>
    ///     SYNC
    /// </summary>
    Sync = 1UL << 4,

    /// <summary>
    ///     PLAY
    /// </summary>
    Play = 1UL << 5,

    /// <summary>
    ///     PARTY_PRIVACY_FRIENDS
    /// </summary>
    PartyPrivacyFriends = 1UL << 6,

    /// <summary>
    ///     PARTY_PRIVACY_VOICE_CHANNEL
    /// </summary>
    PartyPrivacyVoiceChannel = 1UL << 7,

    /// <summary>
    ///     EMBEDDED
    /// </summary>
    Embedded = 1UL << 8
}