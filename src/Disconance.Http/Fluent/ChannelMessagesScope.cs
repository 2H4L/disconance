using Disconance.Http.Builders.Messages;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Message operations for a channel.
/// </summary>
public sealed class ChannelMessagesScope(IDiscordRequestSender sender, Snowflake channelId)
{
    /// <summary>
    ///     Creates a message.
    /// </summary>
    public CreateMessageRequestBuilder Create()
    {
        return new CreateMessageRequestBuilder(channelId, sender);
    }

    /// <summary>
    ///     Edits a message.
    /// </summary>
    public EditMessageRequestBuilder Edit(Snowflake messageId)
    {
        return new EditMessageRequestBuilder(channelId, messageId, sender);
    }

    /// <summary>
    ///     Gets a message.
    /// </summary>
    public GetChannelMessageRequestBuilder Get(Snowflake messageId)
    {
        return new GetChannelMessageRequestBuilder(channelId, messageId, sender);
    }

    /// <summary>
    ///     Deletes a message.
    /// </summary>
    public DeleteMessageRequestBuilder Delete(Snowflake messageId)
    {
        return new DeleteMessageRequestBuilder(channelId, messageId, sender);
    }

    /// <summary>
    ///     Lists a single page of messages.
    /// </summary>
    public GetChannelMessagesRequestBuilder List()
    {
        return new GetChannelMessagesRequestBuilder(channelId, sender);
    }
}