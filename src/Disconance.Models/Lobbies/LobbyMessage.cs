using Disconance.Models.Messages;
using Disconance.Models.Users;

namespace Disconance.Models.Lobbies;

/// <summary>
///     Lobby Message data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
public class LobbyMessage
{
    /// <summary>
    ///     Id of the message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Message type.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-types" />
    public required MessageType Type { get; set; }

    /// <summary>
    ///     Message content.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>content</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public required string Content { get; set; }

    /// <summary>
    ///     Id of the lobby this message was sent to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>lobby_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public required Snowflake LobbyId { get; set; }

    /// <summary>
    ///     Included for compatibility with the messages interface; equal to <c>lobby_id</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public required Snowflake ChannelId { get; set; }

    /// <summary>
    ///     The user who sent the message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>author</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object" />
    public required User Author { get; set; }

    /// <summary>
    ///     Contains a single <c>additional_name</c> string — the author's lobby member additional display name,
    ///     captured when the message was sent. Omitted if the author had no <c>additional_name</c> set.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>lobby_member</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public Optional<LobbyMember> LobbyMember { get; set; }

    /// <summary>
    ///     Dispatch-only metadata sent with the message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>metadata</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public Optional<Dictionary<string, string>?> Metadata { get; set; }

    /// <summary>
    ///     Moderation metadata set via Update Lobby Message Moderation Metadata.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>moderation_metadata</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public Optional<Dictionary<string, string>?> ModerationMetadata { get; set; }

    /// <summary>
    ///     Message flags bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-flags" />
    public required MessageFlags Flags { get; set; }

    /// <summary>
    ///     The application that sent the message.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/lobby#lobby-message-object" />
    public required Snowflake ApplicationId { get; set; }
}