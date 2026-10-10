namespace Disconance.Models.Teams;

/// <summary>
///     Membership State Enum defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-membership-state-enum" />
public enum MembershipState
{
    /// <summary>
    ///     INVITED
    /// </summary>
    Invited = 1,

    /// <summary>
    ///     ACCEPTED
    /// </summary>
    Accepted = 2
}