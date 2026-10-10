namespace Disconance.Models.Invites;

/// <summary>
///     Invite Target Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-target-types" />
public enum InviteTargetType
{
    /// <summary>
    ///     STREAM
    /// </summary>
    Stream = 1,

    /// <summary>
    ///     EMBEDDED_APPLICATION
    /// </summary>
    EmbeddedApplication = 2
}