using Disconance.Http.Responses;
using Disconance.Models;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     DELETE channels/{channel.id}/messages/{message.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#delete-message" />
public sealed class DeleteMessageRequest(Snowflake channelId, Snowflake messageId)
    : EndpointRequest<NoContent>(HttpMethod.Delete,
        new DiscordRoute("channels/{channel.id}/messages/{message.id}",
            new Dictionary<string, string>
                { ["channel.id"] = channelId.ToString(), ["message.id"] = messageId.ToString() }));