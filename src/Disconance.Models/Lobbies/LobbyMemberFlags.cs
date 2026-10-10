namespace Disconance.Models.Lobbies;

/// <summary>
///     Lobby Member Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-flags" />
[Flags]
public enum LobbyMemberFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     User can link a text channel to a lobby.
    /// </summary>
    CanLinkLobby = 1UL << 0
}