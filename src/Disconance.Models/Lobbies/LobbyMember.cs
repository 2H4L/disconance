namespace Disconance.Models.Lobbies;

/// <summary>
///     Lobby Member data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-structure" />
public class LobbyMember
{
    /// <summary>
    ///     The id of the user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Dictionary of string key/value pairs. The max total length is 1000.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>metadata</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-structure" />
    public Optional<Dictionary<string, string>?> Metadata { get; set; }

    /// <summary>
    ///     Lobby member flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<LobbyMemberFlags> Flags { get; set; }

    /// <summary>
    ///     An additional 1-80 character display name for the member, such as an in-game character name. Can only be set
    ///     through the HTTP API, not from a Social SDK client. Accessible via the Social SDK with [
    ///     <c>MessageHandle::AdditionalName</c> ].
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>additional_name</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/lobby#lobby-member-object-lobby-member-structure" />
    public Optional<string> AdditionalName { get; set; }
}