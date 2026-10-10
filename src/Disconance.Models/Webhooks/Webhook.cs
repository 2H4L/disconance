using Disconance.Models.Channels;
using Disconance.Models.Guilds;
using Disconance.Models.Users;

namespace Disconance.Models.Webhooks;

/// <summary>
///     Webhook data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
public class Webhook
{
    /// <summary>
    ///     The id of the webhook.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The type of the webhook.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public required WebhookType Type { get; set; }

    /// <summary>
    ///     The guild id this webhook is for, if any.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public Optional<Snowflake?> GuildId { get; set; }

    /// <summary>
    ///     The channel id this webhook is for, if any.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public required Snowflake? ChannelId { get; set; }

    /// <summary>
    ///     The user this webhook was created by (not returned when getting a webhook with its token).
    /// </summary>
    /// <remarks>Discord field: <c>user</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     The default name of the webhook.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public required string? Name { get; set; }

    /// <summary>
    ///     The default user avatar hash of the webhook.
    /// </summary>
    /// <remarks>Discord field: <c>avatar</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Avatar { get; set; }

    /// <summary>
    ///     The secure token of the webhook (returned for Incoming Webhooks).
    /// </summary>
    /// <remarks>Discord field: <c>token</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public Optional<string> Token { get; set; }

    /// <summary>
    ///     The bot/OAuth2 application that created this webhook.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public required Snowflake? ApplicationId { get; set; }

    /// <summary>
    ///     The guild of the channel that this webhook is following (returned for Channel Follower Webhooks).
    /// </summary>
    /// <remarks>Discord field: <c>source_guild</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public Optional<PartialGuild> SourceGuild { get; set; }

    /// <summary>
    ///     The channel that this webhook is following (returned for Channel Follower Webhooks).
    /// </summary>
    /// <remarks>Discord field: <c>source_channel</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    public Optional<PartialChannel> SourceChannel { get; set; }

    /// <summary>
    ///     The url used for executing the webhook (returned by the webhooks OAuth2 flow).
    /// </summary>
    /// <remarks>Discord field: <c>url</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-structure" />
    /// <seealso href="https://docs.discord.com/developers/topics/oauth2#webhooks" />
    public Optional<string> Url { get; set; }
}