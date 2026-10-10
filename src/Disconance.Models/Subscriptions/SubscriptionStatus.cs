namespace Disconance.Models.Subscriptions;

/// <summary>
///     Subscription Statuses defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-statuses" />
public enum SubscriptionStatus
{
    /// <summary>
    ///     Subscription is active and scheduled to renew.
    /// </summary>
    Active = 0,

    /// <summary>
    ///     Subscription is inactive and not being charged.
    /// </summary>
    Inactive = 1,

    /// <summary>
    ///     Subscription is active but will not renew.
    /// </summary>
    Ending = 2
}