namespace Disconance.Models.Teams;

/// <summary>
///     Known Discord team member role types. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/teams#team-member-roles-team-member-role-types" />
public static class TeamMemberRole
{
    /// <summary>
    ///     Admins have similar access as owners, except they cannot take destructive actions on the team or team-owned
    ///     apps.
    /// </summary>
    public const string Admin = "admin";

    /// <summary>
    ///     Developers can access information about team-owned apps, like the client secret or public key. They can also
    ///     take limited actions on team-owned apps, like configuring interaction endpoints or resetting the bot token.
    ///     Members with the Developer role *cannot* manage the team or its members, or take destructive actions on
    ///     team-owned apps.
    /// </summary>
    public const string Developer = "developer";

    /// <summary>
    ///     Read-only members can access information about a team and any team-owned apps. Some examples include getting
    ///     the IDs of applications and exporting payout records. Members can also invite bots associated with
    ///     team-owned apps that are marked private.
    /// </summary>
    public const string ReadOnly = "read_only";
}