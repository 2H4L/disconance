using Disconance.Models.Guilds;
using Disconance.Models.Teams;
using Disconance.Models.Users;

namespace Disconance.Models.Applications;

/// <summary>
///     A partial Application resource. Each field may be absent; consult the source context for the supplied subset.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
public class PartialApplication
{
    /// <summary>
    ///     ID of the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     Name of the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     Icon hash of the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Icon { get; set; }

    /// <summary>
    ///     Description of the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     List of RPC origin URLs, if RPC is enabled.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>rpc_origins</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<List<string>> RpcOrigins { get; set; }

    /// <summary>
    ///     When <c>false</c> , only the app owner can add the app to guilds.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bot_public</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<bool> BotPublic { get; set; }

    /// <summary>
    ///     When <c>true</c> , the app's bot will only join upon completion of the full OAuth2 code grant flow.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bot_require_code_grant</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<bool> BotRequireCodeGrant { get; set; }

    /// <summary>
    ///     Partial user object for the bot user associated with the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bot</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<PartialUser> Bot { get; set; }

    /// <summary>
    ///     URL of the app's Terms of Service.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>terms_of_service_url</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> TermsOfServiceUrl { get; set; }

    /// <summary>
    ///     URL of the app's Privacy Policy.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>privacy_policy_url</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> PrivacyPolicyUrl { get; set; }

    /// <summary>
    ///     Partial user object for the owner of the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>owner</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<PartialUser> Owner { get; set; }

    /// <summary>
    ///     Hex encoded key for verification in interactions and the GameSDK's GetTicket.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>verify_key</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> VerifyKey { get; set; }

    /// <summary>
    ///     If the app belongs to a team, this will be a list of the members of that team.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>team</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<Team?> Team { get; set; }

    /// <summary>
    ///     Guild associated with the app. For example, a developer support server.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     Partial object of the associated guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<PartialGuild> Guild { get; set; }

    /// <summary>
    ///     If this app is a game sold on Discord, this field will be the id of the "Game SKU" that is created, if
    ///     exists.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>primary_sku_id</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<Snowflake> PrimarySkuId { get; set; }

    /// <summary>
    ///     If this app is a game sold on Discord, this field will be the URL slug that links to the store page.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>slug</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> Slug { get; set; }

    /// <summary>
    ///     App's default rich presence invite cover image hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>cover_image</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string> CoverImage { get; set; }

    /// <summary>
    ///     App's legacy public flags.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<ApplicationFlags> Flags { get; set; }

    /// <summary>
    ///     App's public flags.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags_new</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<ApplicationFlags> FlagsNew { get; set; }

    /// <summary>
    ///     Approximate count of guilds the app has been added to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>approximate_guild_count</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<int> ApproximateGuildCount { get; set; }

    /// <summary>
    ///     Approximate count of users that have installed the app (authorized with <c>application.commands</c> as a
    ///     scope).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>approximate_user_install_count</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<int> ApproximateUserInstallCount { get; set; }

    /// <summary>
    ///     Approximate count of users that have OAuth2 authorizations for the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>approximate_user_authorization_count</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<int> ApproximateUserAuthorizationCount { get; set; }

    /// <summary>
    ///     Array of redirect URIs for the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>redirect_uris</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<List<string>> RedirectUris { get; set; }

    /// <summary>
    ///     Interactions endpoint URL for the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>interactions_endpoint_url</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#receiving-an-interaction" />
    public Optional<string?> InteractionsEndpointUrl { get; set; }

    /// <summary>
    ///     Role connection verification URL for the app.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>role_connections_verification_url</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string?> RoleConnectionsVerificationUrl { get; set; }

    /// <summary>
    ///     Event webhooks URL for the app to receive webhook events.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>event_webhooks_url</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso href="https://docs.discord.com/developers/events/webhook-events#preparing-for-events" />
    public Optional<string?> EventWebhooksUrl { get; set; }

    /// <summary>
    ///     If webhook events are enabled for the app. <c>1</c> (default) means disabled, <c>2</c> means enabled, and
    ///     <c>3</c> means disabled by Discord.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>event_webhooks_status</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso href="https://docs.discord.com/developers/events/webhook-events" />
    public Optional<ApplicationEventWebhookStatus> EventWebhooksStatus { get; set; }

    /// <summary>
    ///     List of Webhook event types the app subscribes to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>event_webhooks_types</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    /// <seealso href="https://docs.discord.com/developers/events/webhook-events#event-types" />
    public Optional<List<string>> EventWebhooksTypes { get; set; }

    /// <summary>
    ///     List of tags describing the content and functionality of the app. Max of 5 tags.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>tags</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<List<string>> Tags { get; set; }

    /// <summary>
    ///     Settings for the app's default in-app authorization link, if enabled.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>install_params</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<InstallParams> InstallParams { get; set; }

    /// <summary>
    ///     Default scopes and permissions for each supported installation context. Value for each key is an integration
    ///     type configuration object.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>integration_types_config</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<Dictionary<ApplicationIntegrationType, ApplicationIntegrationTypeConfiguration>>
        IntegrationTypesConfig { get; set; }

    /// <summary>
    ///     Default custom authorization URL for the app, if enabled.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_install_url</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application#application-object-application-structure" />
    public Optional<string> CustomInstallUrl { get; set; }
}