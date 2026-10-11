namespace Disconance.Models.Voice;

/// <summary>
///     Voice Region data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
public class VoiceRegion
{
    /// <summary>
    ///     Unique ID for the region.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
    public required string Id { get; set; }

    /// <summary>
    ///     Name of the region.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     True for a single server that is closest to the current user's client.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>optimal</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
    public required bool Optimal { get; set; }

    /// <summary>
    ///     Whether this is a deprecated voice region (avoid switching to these).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>deprecated</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
    public required bool Deprecated { get; set; }

    /// <summary>
    ///     Whether this is a custom voice region (used for events/etc).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/voice#voice-region-object-voice-region-structure" />
    public required bool Custom { get; set; }
}