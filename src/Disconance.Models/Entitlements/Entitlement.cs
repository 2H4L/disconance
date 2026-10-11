namespace Disconance.Models.Entitlements;

/// <summary>
///     Entitlement data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
public class Entitlement
{
    /// <summary>
    ///     ID of the entitlement.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     ID of the SKU.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required Snowflake SkuId { get; set; }

    /// <summary>
    ///     ID of the parent application.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application_id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     ID of the user that is granted access to the entitlement's sku.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public Optional<Snowflake> UserId { get; set; }

    /// <summary>
    ///     Type of entitlement.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required EntitlementType Type { get; set; }

    /// <summary>
    ///     Entitlement was deleted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>deleted</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required bool Deleted { get; set; }

    /// <summary>
    ///     Start date at which the entitlement is valid.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>starts_at</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required DateTimeOffset? StartsAt { get; set; }

    /// <summary>
    ///     Date at which the entitlement is no longer valid.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>ends_at</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public required DateTimeOffset? EndsAt { get; set; }

    /// <summary>
    ///     ID of the guild that is granted access to the entitlement's sku.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     For consumable items, whether or not the entitlement has been consumed.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>consumed</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/entitlement#entitlement-object-entitlement-structure" />
    public Optional<bool> Consumed { get; set; }
}