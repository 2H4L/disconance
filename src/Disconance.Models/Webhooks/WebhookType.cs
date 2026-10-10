namespace Disconance.Models.Webhooks;

/// <summary>
///     Webhook Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/webhook#webhook-object-webhook-types" />
public enum WebhookType
{
    /// <summary>
    ///     Incoming Webhooks can post messages to channels with a generated token.
    /// </summary>
    Incoming = 1,

    /// <summary>
    ///     Channel Follower Webhooks are internal webhooks used with Channel Following to post new messages into
    ///     channels.
    /// </summary>
    ChannelFollower = 2,

    /// <summary>
    ///     Application webhooks are webhooks used with Interactions.
    /// </summary>
    Application = 3
}