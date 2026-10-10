namespace Disconance.Models.Components;

/// <summary>
///     Unfurled Media Item Flags defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#unfurled-media-item-unfurled-media-item-flags" />
[Flags]
public enum UnfurledMediaItemFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This image is animated.
    /// </summary>
    IsAnimated = 1UL << 0
}