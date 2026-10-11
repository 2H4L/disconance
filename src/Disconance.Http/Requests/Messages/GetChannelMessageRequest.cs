using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     GET channels/{channel.id}/messages/{message.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#get-channel-message" />
public sealed class GetChannelMessageRequest(Snowflake channelId, Snowflake messageId)
    : EndpointRequest<Message>(HttpMethod.Get,
        new DiscordRoute("channels/{channel.id}/messages/{message.id}",
            new Dictionary<string, string>
                { ["channel.id"] = channelId.ToString(), ["message.id"] = messageId.ToString() }));