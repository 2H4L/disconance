namespace Disconance.Models.OAuth2;

/// <summary>
///     Known Discord OAuth2 scopes. String fields allow additional scopes as Discord adds them.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/oauth2#shared-resources-oauth2-scopes" />
public static class OAuth2Scope
{
    /// <summary>
    ///     Allows your app to fetch data from a user's "Now Playing/Recently Played" list — not currently available for
    ///     apps.
    /// </summary>
    public const string ActivitiesRead = "activities.read";

    /// <summary>
    ///     Allows your app to update a user's activity - not currently available for apps (NOT REQUIRED FOR GAMESDK
    ///     ACTIVITY MANAGER).
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/developer-tools/game-sdk#activities" />
    public const string ActivitiesWrite = "activities.write";

    /// <summary>
    ///     Allows your app to read build data for a user's applications.
    /// </summary>
    public const string ApplicationsBuildsRead = "applications.builds.read";

    /// <summary>
    ///     Allows your app to upload/update builds for a user's applications - only available to approved partners.
    /// </summary>
    public const string ApplicationsBuildsUpload = "applications.builds.upload";

    /// <summary>
    ///     Allows your app to add commands to a guild - included by default with the <c>bot</c> scope.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public const string ApplicationsCommands = "applications.commands";

    /// <summary>
    ///     Allows your app to update its commands using a Bearer token - client credentials grant only.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    /// <seealso href="https://docs.discord.com/developers/topics/oauth2#client-credentials-grant" />
    public const string ApplicationsCommandsUpdate = "applications.commands.update";

    /// <summary>
    ///     Allows your app to update permissions for its commands in a guild a user has permissions to.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#permissions" />
    public const string ApplicationsCommandsPermissionsUpdate = "applications.commands.permissions.update";

    /// <summary>
    ///     Allows your app to read entitlements for a user's applications.
    /// </summary>
    public const string ApplicationsEntitlements = "applications.entitlements";

    /// <summary>
    ///     Allows your app to read and update store data (SKUs, store listings, achievements, etc.) for a user's
    ///     applications.
    /// </summary>
    public const string ApplicationsStoreUpdate = "applications.store.update";

    /// <summary>
    ///     For oauth2 bots, this puts the bot in the user's selected guild by default.
    /// </summary>
    public const string Bot = "bot";

    /// <summary>
    ///     Allows <c>/users/@me/connections</c> to return linked third-party accounts.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user-connections" />
    public const string Connections = "connections";

    /// <summary>
    ///     Allows your app to see information about the user's DMs and group DMs - only available to approved partners.
    /// </summary>
    public const string DmChannelsRead = "dm_channels.read";

    /// <summary>
    ///     Enables <c>/users/@me</c> to return an <c>email</c> .
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user" />
    public const string Email = "email";

    /// <summary>
    ///     Allows your app to join users to a group dm.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#group-dm-add-recipient" />
    public const string GdmJoin = "gdm.join";

    /// <summary>
    ///     Allows <c>/users/@me/guilds</c> to return basic information about all of a user's guilds.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user-guilds" />
    public const string Guilds = "guilds";

    /// <summary>
    ///     Allows <c>/guilds/{guild.id}/members/{user.id}</c> to be used for joining users to a guild.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#add-guild-member" />
    public const string GuildsJoin = "guilds.join";

    /// <summary>
    ///     Allows <c>/users/@me/guilds/{guild.id}/member</c> to return a user's member information in a guild.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user-guild-member" />
    public const string GuildsMembersRead = "guilds.members.read";

    /// <summary>
    ///     Allows <c>/users/@me</c> without <c>email</c> .
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#get-current-user" />
    public const string Identify = "identify";

    /// <summary>
    ///     Allows your app to read a user's Nitro subscription type as defined by <c>premium_type</c> on the User
    ///     object - only available to approved partners.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public const string IdentifyPremium = "identify.premium";

    /// <summary>
    ///     For local rpc server api access, this allows you to read messages from all client channels (otherwise
    ///     restricted to channels/guilds your app creates).
    /// </summary>
    public const string MessagesRead = "messages.read";

    /// <summary>
    ///     Allows your app to access a user’s Discord Friends list, their pending requests, and blocked users. This
    ///     scope is part of our Social SDK - submit for access here. Social SDK Terms apply, including Section 5(a)(ii)
    ///     to the data you obtain.
    /// </summary>
    /// <seealso href="https://discord.com/developers/applications/select/social-sdk/getting-started" />
    /// <seealso href="https://support-dev.discord.com/hc/en-us/articles/30225844245271-Discord-Social-SDK-Terms" />
    public const string RelationshipsRead = "relationships.read";

    /// <summary>
    ///     Allows your app to update a user's connection and metadata for the app.
    /// </summary>
    public const string RoleConnectionsWrite = "role_connections.write";

    /// <summary>
    ///     For local rpc server access, this allows you to control a user's local Discord client - only available to
    ///     approved partners.
    /// </summary>
    public const string Rpc = "rpc";

    /// <summary>
    ///     For local rpc server access, this allows you to update a user's activity - only available to approved
    ///     partners.
    /// </summary>
    public const string RpcActivitiesWrite = "rpc.activities.write";

    /// <summary>
    ///     For local rpc server access, this allows you to receive notifications pushed out to the user - only
    ///     available to approved partners.
    /// </summary>
    public const string RpcNotificationsRead = "rpc.notifications.read";

    /// <summary>
    ///     For local rpc server access, this allows you to read a user's voice settings and listen for voice events -
    ///     only available to approved partners.
    /// </summary>
    public const string RpcVoiceRead = "rpc.voice.read";

    /// <summary>
    ///     For local rpc server access, this allows you to update a user's voice settings - only available to approved
    ///     partners.
    /// </summary>
    public const string RpcVoiceWrite = "rpc.voice.write";

    /// <summary>
    ///     Allows your app to connect to voice on user's behalf and see all the voice members - only available to
    ///     approved partners.
    /// </summary>
    public const string Voice = "voice";

    /// <summary>
    ///     This generates a webhook that is returned in the oauth token response for authorization code grants.
    /// </summary>
    public const string WebhookIncoming = "webhook.incoming";
}