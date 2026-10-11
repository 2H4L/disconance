using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     A channel-bound fluent scope.
/// </summary>
public sealed class ChannelScope(IDiscordRequestSender sender, Snowflake channelId)
{
    /// <summary>
    ///     Channel message operations.
    /// </summary>
    public ChannelMessagesScope Messages { get; } = new(sender, channelId);
}