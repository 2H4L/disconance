using Disconance.Models.Applications;
using Disconance.Models.Permissions;

namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public class ApplicationCommand
{
    /// <summary>
    ///     Unique ID of command.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of command, defaults to <c>1</c> .
    /// </summary>
    /// <remarks>Discord field: <c>type</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<ApplicationCommandType> Type { get; set; }

    /// <summary>
    ///     ID of the parent application.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     Guild ID of the command, if not global.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     Name of command, 1-32 characters.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     Localization dictionary for <c>name</c> field. Values follow the same restrictions as <c>name</c> .
    /// </summary>
    /// <remarks>Discord field: <c>name_localizations</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<Dictionary<string, string>?> NameLocalizations { get; set; }

    /// <summary>
    ///     Description for <c>CHAT_INPUT</c> and <c>PRIMARY_ENTRY_POINT</c> commands, 1-100 characters. Empty string
    ///     for <c>USER</c> and <c>MESSAGE</c> commands.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Description { get; set; }

    /// <summary>
    ///     Localization dictionary for <c>description</c> field. Values follow the same restrictions as
    ///     <c>description</c> .
    /// </summary>
    /// <remarks>Discord field: <c>description_localizations</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<Dictionary<string, string>?> DescriptionLocalizations { get; set; }

    /// <summary>
    ///     Parameters for the command, max of 25.
    /// </summary>
    /// <remarks>Discord field: <c>options</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<List<ApplicationCommandOption>> Options { get; set; }

    /// <summary>
    ///     Set of permissions represented as a bit set.
    /// </summary>
    /// <remarks>Discord field: <c>default_member_permissions</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions" />
    public required PermissionFlags? DefaultMemberPermissions { get; set; }

    /// <summary>
    ///     Deprecated (use <c>contexts</c> instead); Indicates whether the command is available in DMs with the app,
    ///     only for globally-scoped commands. By default, commands are visible.
    /// </summary>
    /// <remarks>Discord field: <c>dm_permission</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<bool> DmPermission { get; set; }

    /// <summary>
    ///     Not recommended for use as field will soon be deprecated. Indicates whether the command is enabled by
    ///     default when the app is added to a guild, defaults to <c>true</c> .
    /// </summary>
    /// <remarks>Discord field: <c>default_permission</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<bool?> DefaultPermission { get; set; }

    /// <summary>
    ///     Indicates whether the command is age-restricted, defaults to <c>false</c> .
    /// </summary>
    /// <remarks>Discord field: <c>nsfw</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<bool> Nsfw { get; set; }

    /// <summary>
    ///     Installation contexts where the command is available, only for globally-scoped commands. Defaults to your
    ///     app's configured contexts.
    /// </summary>
    /// <remarks>Discord field: <c>integration_types</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    /// <seealso href="https://docs.discord.com/developers/resources/application#installation-context" />
    public Optional<List<ApplicationIntegrationType>> IntegrationTypes { get; set; }

    /// <summary>
    ///     Interaction context(s) where the command can be used, only for globally-scoped commands.
    /// </summary>
    /// <remarks>Discord field: <c>contexts</c>. May be omitted. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<List<InteractionContextType>?> Contexts { get; set; }

    /// <summary>
    ///     Autoincrementing version identifier updated during substantial record changes.
    /// </summary>
    /// <remarks>Discord field: <c>version</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required Snowflake Version { get; set; }

    /// <summary>
    ///     Determines whether the interaction is handled by the app's interactions handler or by Discord.
    /// </summary>
    /// <remarks>Discord field: <c>handler</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<EntryPointCommandHandlerType> Handler { get; set; }
}