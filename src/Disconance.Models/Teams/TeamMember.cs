using Disconance.Models.Users;

namespace Disconance.Models.Teams;

/// <summary>
///     Team Member data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-member-object" />
public class TeamMember
{
    /// <summary>
    ///     User's membership state on the team.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>membership_state</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-member-object" />
    public required MembershipState MembershipState { get; set; }

    /// <summary>
    ///     ID of the parent team of which they are a member.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>team_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-member-object" />
    public required Snowflake TeamId { get; set; }

    /// <summary>
    ///     User object of the team member.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-member-object" />
    public required User User { get; set; }

    /// <summary>
    ///     Role of the team member.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>role</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-member-object" />
    public required string Role { get; set; }
}