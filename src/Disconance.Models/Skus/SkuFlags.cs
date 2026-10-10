namespace Disconance.Models.Skus;

/// <summary>
///     SKU Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/sku#sku-object-sku-flags" />
[Flags]
public enum SkuFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     SKU is available for purchase.
    /// </summary>
    Available = 1UL << 2,

    /// <summary>
    ///     Recurring SKU that can be purchased by a user and applied to a single server. Grants access to every user in
    ///     that server.
    /// </summary>
    GuildSubscription = 1UL << 7,

    /// <summary>
    ///     Recurring SKU purchased by a user for themselves. Grants access to the purchasing user in every server.
    /// </summary>
    UserSubscription = 1UL << 8
}