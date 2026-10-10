namespace Disconance.Models.Messages;

/// <summary>
///     Embed Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-flags" />
[Flags]
public enum EmbedFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     This embed is a fallback for a reply to an activity card.
    /// </summary>
    IsContentInventoryEntry = 1UL << 5
}