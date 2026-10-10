namespace Disconance.Models.Invites;

/// <summary>
///     Invite Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-invite-types" />
public enum InviteType
{
    /// <summary>
    ///     GUILD
    /// </summary>
    Guild = 0,

    /// <summary>
    ///     GROUP_DM
    /// </summary>
    GroupDm = 1,

    /// <summary>
    ///     FRIEND
    /// </summary>
    Friend = 2
}