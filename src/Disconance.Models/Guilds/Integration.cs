using Disconance.Models.Users;

namespace Disconance.Models.Guilds;

/// <summary>
///     Integration data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
public class Integration
{
    /// <summary>
    ///     Integration id.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Integration name.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Integration type (twitch, youtube, discord, or guild_subscription).
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public required string Type { get; set; }

    /// <summary>
    ///     Is this integration enabled.
    /// </summary>
    /// <remarks>Discord field: <c>enabled</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public required bool Enabled { get; set; }

    /// <summary>
    ///     Is this integration syncing.
    /// </summary>
    /// <remarks>Discord field: <c>syncing</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<bool> Syncing { get; set; }

    /// <summary>
    ///     Id that this integration uses for "subscribers".
    /// </summary>
    /// <remarks>Discord field: <c>role_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<Snowflake> RoleId { get; set; }

    /// <summary>
    ///     Whether emoticons should be synced for this integration (twitch only currently).
    /// </summary>
    /// <remarks>Discord field: <c>enable_emoticons</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<bool> EnableEmoticons { get; set; }

    /// <summary>
    ///     The behavior of expiring subscribers.
    /// </summary>
    /// <remarks>Discord field: <c>expire_behavior</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<IntegrationExpireBehavior> ExpireBehavior { get; set; }

    /// <summary>
    ///     The grace period (in days) before expiring subscribers.
    /// </summary>
    /// <remarks>Discord field: <c>expire_grace_period</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<int> ExpireGracePeriod { get; set; }

    /// <summary>
    ///     User for this integration.
    /// </summary>
    /// <remarks>Discord field: <c>user</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     Integration account information.
    /// </summary>
    /// <remarks>Discord field: <c>account</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public required IntegrationAccount Account { get; set; }

    /// <summary>
    ///     When this integration was last synced.
    /// </summary>
    /// <remarks>Discord field: <c>synced_at</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<DateTimeOffset> SyncedAt { get; set; }

    /// <summary>
    ///     How many subscribers this integration has.
    /// </summary>
    /// <remarks>Discord field: <c>subscriber_count</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<int> SubscriberCount { get; set; }

    /// <summary>
    ///     Has this integration been revoked.
    /// </summary>
    /// <remarks>Discord field: <c>revoked</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<bool> Revoked { get; set; }

    /// <summary>
    ///     The bot/OAuth2 application for discord integrations.
    /// </summary>
    /// <remarks>Discord field: <c>application</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<IntegrationApplication> Application { get; set; }

    /// <summary>
    ///     The scopes the application has been authorized for.
    /// </summary>
    /// <remarks>Discord field: <c>scopes</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object-integration-structure" />
    public Optional<List<string>> Scopes { get; set; }
}