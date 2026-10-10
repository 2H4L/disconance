namespace Disconance.Models.Channels;

/// <summary>
///     Video Quality Modes defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-video-quality-modes" />
public enum VideoQualityMode
{
    /// <summary>
    ///     Discord chooses the quality for optimal performance.
    /// </summary>
    Auto = 1,

    /// <summary>
    ///     720p
    /// </summary>
    Full = 2
}