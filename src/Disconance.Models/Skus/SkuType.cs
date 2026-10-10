namespace Disconance.Models.Skus;

/// <summary>
///     SKU Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-types" />
public enum SkuType
{
    /// <summary>
    ///     Durable one-time purchase.
    /// </summary>
    Durable = 2,

    /// <summary>
    ///     Consumable one-time purchase.
    /// </summary>
    Consumable = 3,

    /// <summary>
    ///     Represents a recurring subscription.
    /// </summary>
    Subscription = 5,

    /// <summary>
    ///     System-generated group for each SUBSCRIPTION SKU created.
    /// </summary>
    SubscriptionGroup = 6
}