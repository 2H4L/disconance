namespace Disconance.Models.Messages;

/// <summary>
///     Embed Media Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-media-flags" />
[Flags]
public enum EmbedMediaFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This image is animated.
    /// </summary>
    IsAnimated = 1UL << 5
}