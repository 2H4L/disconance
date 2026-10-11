using Disconance.Models.Applications;
using Disconance.Models.Channels;
using Disconance.Models.Entitlements;
using Disconance.Models.Guilds;
using Disconance.Models.Messages;
using Disconance.Models.Permissions;
using Disconance.Models.Users;

namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class Interaction
{
    /// <summary>
    ///     ID of the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     ID of the application this interaction is for.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>application_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     Type of interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required InteractionType Type { get; set; }

    /// <summary>
    ///     Interaction data payload.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>data</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<InteractionData> Data { get; set; }

    /// <summary>
    ///     Guild that the interaction was sent from.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<PartialGuild> Guild { get; set; }

    /// <summary>
    ///     Guild that the interaction was sent from.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     Channel that the interaction was sent from.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<PartialChannel> Channel { get; set; }

    /// <summary>
    ///     Channel that the interaction was sent from.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel_id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Snowflake> ChannelId { get; set; }

    /// <summary>
    ///     Guild member data for the invoking user, including permissions.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>member</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<GuildMember> Member { get; set; }

    /// <summary>
    ///     User object for the invoking user, if invoked in a DM.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     Continuation token for responding to the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>token</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required string Token { get; set; }

    /// <summary>
    ///     Read-only property, always <c>1</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>version</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required int Version { get; set; }

    /// <summary>
    ///     For components or modals triggered by components, the message they were attached to.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>message</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Message> Message { get; set; }

    /// <summary>
    ///     Bitwise set of permissions the app has in the source location of the interaction.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>app_permissions</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required PermissionFlags AppPermissions { get; set; }

    /// <summary>
    ///     Selected language of the invoking user.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>locale</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#locales" />
    public Optional<string> Locale { get; set; }

    /// <summary>
    ///     Guild's preferred locale, if invoked in a guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>guild_locale</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object" />
    public Optional<string> GuildLocale { get; set; }

    /// <summary>
    ///     For monetized apps, any entitlements for the invoking user, representing access to premium SKUs.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>entitlements</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    /// <seealso href="https://docs.discord.com/developers/monetization/overview" />
    /// <seealso href="https://docs.discord.com/developers/resources/sku" />
    public required List<Entitlement> Entitlements { get; set; }

    /// <summary>
    ///     Mapping of installation contexts that the interaction was authorized for to related user or guild IDs. See
    ///     Authorizing Integration Owners Object for details.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>authorizing_integration_owners</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required Dictionary<ApplicationIntegrationType, Snowflake> AuthorizingIntegrationOwners { get; set; }

    /// <summary>
    ///     Context where the interaction was triggered from.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>context</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<InteractionContextType> Context { get; set; }

    /// <summary>
    ///     Attachment size limit in bytes.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>attachment_size_limit</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public required int AttachmentSizeLimit { get; set; }
}