using Disconance.Models.Applications;
using Disconance.Models.Permissions;

namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Defines an application command independently of registration scope or transport.
///     Unassigned optional fields are omitted.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
public class ApplicationCommandDefinition
{
    /// <summary>
    ///     Discord field <c>name</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public required string Name { get; set; }

    /// <summary>
    ///     Discord field <c>type</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public required ApplicationCommandType Type { get; set; }

    /// <summary>
    ///     Discord field <c>name_localizations</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<Dictionary<string, string>?> NameLocalizations { get; set; }

    /// <summary>
    ///     Discord field <c>description</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Discord field <c>description_localizations</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<Dictionary<string, string>?> DescriptionLocalizations { get; set; }

    /// <summary>
    ///     Discord field <c>options</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<List<ApplicationCommandOption>> Options { get; set; }

    /// <summary>
    ///     Discord field <c>default_member_permissions</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<PermissionFlags?> DefaultMemberPermissions { get; set; }

    /// <summary>
    ///     Discord field <c>dm_permission</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<bool?> DmPermission { get; set; }

    /// <summary>
    ///     Discord field <c>default_permission</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<bool> DefaultPermission { get; set; }

    /// <summary>
    ///     Discord field <c>nsfw</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<bool> Nsfw { get; set; }

    /// <summary>
    ///     Discord field <c>integration_types</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<List<ApplicationIntegrationType>> IntegrationTypes { get; set; }

    /// <summary>
    ///     Discord field <c>contexts</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<List<InteractionContextType>> Contexts { get; set; }

    /// <summary>
    ///     Discord field <c>handler</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#create-global-application-command" />
    public Optional<EntryPointCommandHandlerType> Handler { get; set; }
}