namespace Disconance.Models.Applications;

/// <summary>
///     Application Event Webhook Status defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#application-object" />
public enum ApplicationEventWebhookStatus
{
    /// <summary>
    ///     Webhook events are disabled by developer.
    /// </summary>
    Disabled = 1,

    /// <summary>
    ///     Webhook events are enabled by developer.
    /// </summary>
    Enabled = 2,

    /// <summary>
    ///     Webhook events are disabled by Discord, usually due to inactivity.
    /// </summary>
    DisabledByDiscord = 3
}