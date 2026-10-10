namespace Disconance.Models.Stickers;

/// <summary>
///     Sticker Format Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-format-types" />
public enum StickerFormatType
{
    /// <summary>
    ///     PNG
    /// </summary>
    Png = 1,

    /// <summary>
    ///     APNG
    /// </summary>
    Apng = 2,

    /// <summary>
    ///     LOTTIE
    /// </summary>
    Lottie = 3,

    /// <summary>
    ///     GIF
    /// </summary>
    Gif = 4
}