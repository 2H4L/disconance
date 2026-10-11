using System.Globalization;
using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Requests.Messages;

/// <summary>
///     GET channels/{channel.id}/messages. See Discord for endpoint permissions and limits.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#get-channel-messages" />
public sealed class GetChannelMessagesRequest(Snowflake channelId)
    : EndpointRequest<List<Message>>(HttpMethod.Get,
        new DiscordRoute("channels/{channel.id}/messages",
            new Dictionary<string, string> { ["channel.id"] = channelId.ToString() }))
{
    /// <summary>
    ///     Discord query field <c>before</c>; null omits the parameter.
    /// </summary>
    public Snowflake? Before { get; init; }

    /// <summary>
    ///     Discord query field <c>after</c>; null omits the parameter.
    /// </summary>
    public Snowflake? After { get; init; }

    /// <summary>
    ///     Discord query field <c>around</c>; null omits the parameter.
    /// </summary>
    public Snowflake? Around { get; init; }

    /// <summary>
    ///     Discord query field <c>limit</c>; null omits the parameter.
    /// </summary>
    public int? Limit { get; init; }

    /// <inheritdoc />
    public override IReadOnlyDictionary<string, string?> Query => new Dictionary<string, string?>
    {
        ["before"] = Before?.ToString(),
        ["after"] = After?.ToString(),
        ["around"] = Around?.ToString(),
        ["limit"] = Limit?.ToString(CultureInfo.InvariantCulture)
    };
}