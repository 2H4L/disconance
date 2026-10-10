namespace Disconance.Models.Lobbies;

/// <summary>
///     Lobby Invite data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-invite-object" />
public class LobbyInvite
{
    /// <summary>
    ///     The invite code for the lobby's linked channel.
    /// </summary>
    /// <remarks>Discord field: <c>code</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-invite-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-object" />
    public required string Code { get; set; }
}