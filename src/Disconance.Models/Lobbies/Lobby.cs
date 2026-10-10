using Disconance.Models.Channels;

namespace Disconance.Models.Lobbies;

/// <summary>
///     Lobby data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
public class Lobby
{
    /// <summary>
    ///     The id of this channel.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Application that created the lobby.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     Dictionary of string key/value pairs. The max total length is 1000.
    /// </summary>
    /// <remarks>Discord field: <c>metadata</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
    public required Dictionary<string, string>? Metadata { get; set; }

    /// <summary>
    ///     Members of the lobby.
    /// </summary>
    /// <remarks>Discord field: <c>members</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
    public required List<LobbyMember> Members { get; set; }

    /// <summary>
    ///     The guild channel linked to the lobby.
    /// </summary>
    /// <remarks>Discord field: <c>linked_channel</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-object-lobby-structure" />
    public Optional<Channel> LinkedChannel { get; set; }
}