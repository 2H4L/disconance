using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     POST channels/{channel.id}/messages. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#create-message" />
public sealed class CreateMessageRequest(Snowflake channelId, CreateMessageBody payload)
    : PayloadRequest<Message, CreateMessageBody>(HttpMethod.Post,
        new DiscordRoute("channels/{channel.id}/messages",
            new Dictionary<string, string> { ["channel.id"] = channelId.ToString() }), payload);