namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Member Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-member-object-guild-member-flags" />
[Flags]
public enum GuildMemberFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Member has left and rejoined the guild.
    /// </summary>
    DidRejoin = 1UL << 0,

    /// <summary>
    ///     Member has completed onboarding.
    /// </summary>
    CompletedOnboarding = 1UL << 1,

    /// <summary>
    ///     Member is exempt from guild verification requirements.
    /// </summary>
    BypassesVerification = 1UL << 2,

    /// <summary>
    ///     Member has started onboarding.
    /// </summary>
    StartedOnboarding = 1UL << 3,

    /// <summary>
    ///     Member is a guest and can only access the voice channel they were invited to.
    /// </summary>
    IsGuest = 1UL << 4,

    /// <summary>
    ///     Member has started Server Guide new member actions.
    /// </summary>
    StartedHomeActions = 1UL << 5,

    /// <summary>
    ///     Member has completed Server Guide new member actions.
    /// </summary>
    CompletedHomeActions = 1UL << 6,

    /// <summary>
    ///     Member's username, display name, or nickname is blocked by AutoMod.
    /// </summary>
    AutomodQuarantinedUsername = 1UL << 7,

    /// <summary>
    ///     Member has dismissed the DM settings upsell.
    /// </summary>
    DmSettingsUpsellAcknowledged = 1UL << 9,

    /// <summary>
    ///     Member's guild tag is blocked by AutoMod.
    /// </summary>
    AutomodQuarantinedGuildTag = 1UL << 10
}