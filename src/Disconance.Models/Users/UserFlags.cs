namespace Disconance.Models.Users;

/// <summary>
///     User Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-flags" />
[Flags]
public enum UserFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Discord Employee
    /// </summary>
    Staff = 1UL << 0,

    /// <summary>
    ///     Partnered Server Owner
    /// </summary>
    Partner = 1UL << 1,

    /// <summary>
    ///     HypeSquad Events Member
    /// </summary>
    Hypesquad = 1UL << 2,

    /// <summary>
    ///     Bug Hunter Level 1
    /// </summary>
    BugHunterLevel1 = 1UL << 3,

    /// <summary>
    ///     House Bravery Member
    /// </summary>
    HypesquadOnlineHouse1 = 1UL << 6,

    /// <summary>
    ///     House Brilliance Member
    /// </summary>
    HypesquadOnlineHouse2 = 1UL << 7,

    /// <summary>
    ///     House Balance Member
    /// </summary>
    HypesquadOnlineHouse3 = 1UL << 8,

    /// <summary>
    ///     Early Nitro Supporter
    /// </summary>
    PremiumEarlySupporter = 1UL << 9,

    /// <summary>
    ///     User is a team.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/topics/teams" />
    TeamPseudoUser = 1UL << 10,

    /// <summary>
    ///     Bug Hunter Level 2
    /// </summary>
    BugHunterLevel2 = 1UL << 14,

    /// <summary>
    ///     Verified Bot
    /// </summary>
    VerifiedBot = 1UL << 16,

    /// <summary>
    ///     Early Verified Bot Developer
    /// </summary>
    VerifiedDeveloper = 1UL << 17,

    /// <summary>
    ///     Moderator Programs Alumni
    /// </summary>
    CertifiedModerator = 1UL << 18,

    /// <summary>
    ///     Bot uses only HTTP interactions and is shown in the online member list.
    /// </summary>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#receiving-an-interaction" />
    BotHttpInteractions = 1UL << 19
}