namespace Disconance.Models.Permissions;

/// <summary>
///     Role Tags data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
public class RoleTags
{
    /// <summary>
    ///     The id of the bot this role belongs to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bot_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<Snowflake> BotId { get; set; }

    /// <summary>
    ///     The id of the integration this role belongs to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>integration_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<Snowflake> IntegrationId { get; set; }

    /// <summary>
    ///     Whether this is the guild's Booster role.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>premium_subscriber</c> . May be omitted. Presence represents a literal null marker;
    ///     absence means the flag is unset.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<DiscordNull> PremiumSubscriber { get; set; }

    /// <summary>
    ///     The id of this role's subscription sku and listing.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>subscription_listing_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<Snowflake> SubscriptionListingId { get; set; }

    /// <summary>
    ///     Whether this role is available for purchase.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>available_for_purchase</c> . May be omitted. Presence represents a literal null marker;
    ///     absence means the flag is unset.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<DiscordNull> AvailableForPurchase { get; set; }

    /// <summary>
    ///     Whether this role is a guild's linked role.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_connections</c> . May be omitted. Presence represents a literal null marker; absence
    ///     means the flag is unset.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
    public Optional<DiscordNull> GuildConnections { get; set; }
}