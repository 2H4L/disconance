namespace Disconance.Models.Stickers;

/// <summary>
///     Sticker Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sticker#sticker-object-sticker-types" />
public enum StickerType
{
    /// <summary>
    ///     An official sticker in a pack.
    /// </summary>
    Standard = 1,

    /// <summary>
    ///     A sticker uploaded to a guild for the guild's members.
    /// </summary>
    Guild = 2
}