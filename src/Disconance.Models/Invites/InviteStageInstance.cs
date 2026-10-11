using Disconance.Models.Guilds;

namespace Disconance.Models.Invites;

/// <summary>
///     Invite Stage Instance data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/invite#invite-stage-instance-object" />
public class InviteStageInstance
{
    /// <summary>
    ///     The members speaking in the Stage.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>members</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-stage-instance-object" />
    public required List<PartialGuildMember> Members { get; set; }

    /// <summary>
    ///     The number of users in the Stage.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>participant_count</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-stage-instance-object" />
    public required int ParticipantCount { get; set; }

    /// <summary>
    ///     The number of users speaking in the Stage.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>speaker_count</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-stage-instance-object" />
    public required int SpeakerCount { get; set; }

    /// <summary>
    ///     The topic of the Stage instance (1-120 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>topic</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-stage-instance-object" />
    public required string Topic { get; set; }
}