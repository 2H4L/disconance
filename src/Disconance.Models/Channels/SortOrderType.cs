namespace Disconance.Models.Channels;

/// <summary>
///     Sort Order Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#channel-object-sort-order-types" />
public enum SortOrderType
{
    /// <summary>
    ///     Sort forum posts by activity.
    /// </summary>
    LatestActivity = 0,

    /// <summary>
    ///     Sort forum posts by creation time (from most recent to oldest).
    /// </summary>
    CreationDate = 1
}