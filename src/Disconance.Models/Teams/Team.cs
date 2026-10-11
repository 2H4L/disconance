namespace Disconance.Models.Teams;

/// <summary>
///     Team data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
public class Team
{
    /// <summary>
    ///     Hash of the image of the team's icon.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
    public required string? Icon { get; set; }

    /// <summary>
    ///     Unique ID of the team.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Members of the team.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>members</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
    public required List<TeamMember> Members { get; set; }

    /// <summary>
    ///     Name of the team.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     User ID of the current team owner.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>owner_user_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/teams#data-models-team-object" />
    public required Snowflake OwnerUserId { get; set; }
}