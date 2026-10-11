using Disconance.Models;
using Disconance.Models.Applications;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Permissions;

namespace Disconance.Http.Requests.Commands;

/// <summary>
///     Writable fields for EditApplicationCommandBody. Unassigned optional fields are omitted.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
public class EditApplicationCommandBody
{
    /// <summary>
    ///     Discord field <c>integration_types</c>; global commands only.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<List<ApplicationIntegrationType>> IntegrationTypes { get; set; }

    /// <summary>
    ///     Discord field <c>handler</c>; primary entry point commands only.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<EntryPointCommandHandlerType> Handler { get; set; }

    /// <summary>
    ///     Discord field <c>name</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     Discord field <c>name_localizations</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<Dictionary<string, string>?> NameLocalizations { get; set; }

    /// <summary>
    ///     Discord field <c>description</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Discord field <c>description_localizations</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<Dictionary<string, string>?> DescriptionLocalizations { get; set; }

    /// <summary>
    ///     Discord field <c>options</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<List<ApplicationCommandOption>> Options { get; set; }

    /// <summary>
    ///     Discord field <c>default_member_permissions</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<PermissionFlags?> DefaultMemberPermissions { get; set; }

    /// <summary>
    ///     Discord field <c>dm_permission</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<bool?> DmPermission { get; set; }

    /// <summary>
    ///     Discord field <c>default_permission</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<bool> DefaultPermission { get; set; }

    /// <summary>
    ///     Discord field <c>nsfw</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<bool> Nsfw { get; set; }

    /// <summary>
    ///     Discord field <c>contexts</c>. Consult the endpoint reference for limits and context.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands#edit-global-application-command" />
    public Optional<List<InteractionContextType>> Contexts { get; set; }
}