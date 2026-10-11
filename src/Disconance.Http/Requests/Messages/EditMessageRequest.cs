using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     PATCH channels/{channel.id}/messages/{message.id}. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#edit-message" />
public sealed class EditMessageRequest(Snowflake channelId, Snowflake messageId, EditMessageBody payload)
    : PayloadRequest<Message, EditMessageBody>(HttpMethod.Patch,
        new DiscordRoute("channels/{channel.id}/messages/{message.id}",
            new Dictionary<string, string>
                { ["channel.id"] = channelId.ToString(), ["message.id"] = messageId.ToString() }), payload);