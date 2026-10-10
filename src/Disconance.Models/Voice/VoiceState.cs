using Disconance.Models.Guilds;

namespace Disconance.Models.Voice;

/// <summary>
///     Voice State data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
public class VoiceState
{
    /// <summary>
    ///     The guild id this voice state is for.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     The channel id this user is connected to.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required Snowflake? ChannelId { get; set; }

    /// <summary>
    ///     The user id this voice state is for.
    /// </summary>
    /// <remarks>Discord field: <c>user_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required Snowflake UserId { get; set; }

    /// <summary>
    ///     The guild member this voice state is for.
    /// </summary>
    /// <remarks>Discord field: <c>member</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public Optional<GuildMember> Member { get; set; }

    /// <summary>
    ///     The session id for this voice state.
    /// </summary>
    /// <remarks>Discord field: <c>session_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required string SessionId { get; set; }

    /// <summary>
    ///     Whether this user is deafened by the server.
    /// </summary>
    /// <remarks>Discord field: <c>deaf</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool Deaf { get; set; }

    /// <summary>
    ///     Whether this user is muted by the server.
    /// </summary>
    /// <remarks>Discord field: <c>mute</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool Mute { get; set; }

    /// <summary>
    ///     Whether this user is locally deafened.
    /// </summary>
    /// <remarks>Discord field: <c>self_deaf</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool SelfDeaf { get; set; }

    /// <summary>
    ///     Whether this user is locally muted.
    /// </summary>
    /// <remarks>Discord field: <c>self_mute</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool SelfMute { get; set; }

    /// <summary>
    ///     Whether this user is streaming using "Go Live".
    /// </summary>
    /// <remarks>Discord field: <c>self_stream</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public Optional<bool> SelfStream { get; set; }

    /// <summary>
    ///     Whether this user's camera is enabled.
    /// </summary>
    /// <remarks>Discord field: <c>self_video</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool SelfVideo { get; set; }

    /// <summary>
    ///     Whether this user's permission to speak is denied.
    /// </summary>
    /// <remarks>Discord field: <c>suppress</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required bool Suppress { get; set; }

    /// <summary>
    ///     The time at which the user requested to speak.
    /// </summary>
    /// <remarks>Discord field: <c>request_to_speak_timestamp</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/voice#voice-state-object-voice-state-structure" />
    public required DateTimeOffset? RequestToSpeakTimestamp { get; set; }
}