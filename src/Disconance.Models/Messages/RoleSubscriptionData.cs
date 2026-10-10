namespace Disconance.Models.Messages;

/// <summary>
///     Role Subscription Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#role-subscription-data-object" />
public class RoleSubscriptionData
{
    /// <summary>
    ///     The id of the sku and listing that the user is subscribed to.
    /// </summary>
    /// <remarks>Discord field: <c>role_subscription_listing_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#role-subscription-data-object" />
    public required Snowflake RoleSubscriptionListingId { get; set; }

    /// <summary>
    ///     The name of the tier that the user is subscribed to.
    /// </summary>
    /// <remarks>Discord field: <c>tier_name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#role-subscription-data-object" />
    public required string TierName { get; set; }

    /// <summary>
    ///     The cumulative number of months that the user has been subscribed for.
    /// </summary>
    /// <remarks>Discord field: <c>total_months_subscribed</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#role-subscription-data-object" />
    public required int TotalMonthsSubscribed { get; set; }

    /// <summary>
    ///     Whether this notification is for a renewal rather than a new purchase.
    /// </summary>
    /// <remarks>Discord field: <c>is_renewal</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#role-subscription-data-object" />
    public required bool IsRenewal { get; set; }
}