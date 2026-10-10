namespace Disconance.Models.Invites;

/// <summary>
///     Guild Invite Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object-guild-invite-flags" />
[Flags]
public enum GuildInviteFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This invite is a guest invite for a voice channel.
    /// </summary>
    IsGuestInvite = 1UL << 0
}