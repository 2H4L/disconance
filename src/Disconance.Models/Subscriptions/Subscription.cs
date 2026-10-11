namespace Disconance.Models.Subscriptions;

/// <summary>
///     Subscription data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
public class Subscription
{
    /// <summary>
    ///     ID of the subscription.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     ID of the user who is subscribed.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required Snowflake UserId { get; set; }

    /// <summary>
    ///     List of SKUs subscribed to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_ids</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required List<Snowflake> SkuIds { get; set; }

    /// <summary>
    ///     List of entitlements granted for this subscription.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>entitlement_ids</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required List<Snowflake> EntitlementIds { get; set; }

    /// <summary>
    ///     List of SKUs that this user will be subscribed to at renewal.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>renewal_sku_ids</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required List<Snowflake>? RenewalSkuIds { get; set; }

    /// <summary>
    ///     Start of the current subscription period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_start</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required DateTimeOffset CurrentPeriodStart { get; set; }

    /// <summary>
    ///     End of the current subscription period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_end</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required DateTimeOffset CurrentPeriodEnd { get; set; }

    /// <summary>
    ///     Current status of the subscription.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>status</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required SubscriptionStatus Status { get; set; }

    /// <summary>
    ///     When the subscription was canceled.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>canceled_at</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public required DateTimeOffset? CanceledAt { get; set; }

    /// <summary>
    ///     ISO3166-1 alpha-2 country code of the payment source used to purchase the subscription. Missing unless
    ///     queried with a private OAuth scope.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>country</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/subscription#subscription-object" />
    public Optional<string> Country { get; set; }
}