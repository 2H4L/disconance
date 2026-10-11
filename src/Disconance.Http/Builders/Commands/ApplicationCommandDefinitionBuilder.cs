using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Models;
using Disconance.Models.Applications;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Permissions;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Composes an ApplicationCommandDefinition independently of transport.
/// </summary>
public sealed class
    ApplicationCommandDefinitionBuilder : ModelBuilder<ApplicationCommandDefinition,
    ApplicationCommandDefinitionBuilder>
{
    /// <summary>
    ///     Builds a command definition and checks command-type-specific structure.
    /// </summary>
    public override ApplicationCommandDefinition Build()
    {
        var value = base.Build();

        if (value.Type is ApplicationCommandType.ChatInput or ApplicationCommandType.PrimaryEntryPoint &&
            (!value.Description.HasValue || string.IsNullOrEmpty(value.Description.Value)))
        {
            throw new InvalidOperationException("This command type requires a description.");
        }

        if (value.Type is ApplicationCommandType.User or ApplicationCommandType.Message &&
            (value.Options.HasValue || (value.Description.HasValue && value.Description.Value.Length != 0)))
        {
            throw new InvalidOperationException(
                "Context-menu commands do not accept options or a nonempty description.");
        }

        return value;
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithName(string value)
    {
        return Set("Name", value);
    }

    /// <summary>
    ///     Sets Type; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithType(ApplicationCommandType value)
    {
        return Set("Type", value);
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        return Set("NameLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitNameLocalizations()
    {
        return Set("NameLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public ApplicationCommandDefinitionBuilder ClearNameLocalizations()
    {
        return WithNameLocalizations(null);
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        return Set("DescriptionLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitDescriptionLocalizations()
    {
        return Set("DescriptionLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public ApplicationCommandDefinitionBuilder ClearDescriptionLocalizations()
    {
        return WithDescriptionLocalizations(null);
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        return Set("Options", new Optional<List<ApplicationCommandOption>>(value));
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitOptions()
    {
        return Set("Options", default(Optional<List<ApplicationCommandOption>>));
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public ApplicationCommandDefinitionBuilder AddOption(ApplicationCommandOption value)
    {
        return Add("Options", value);
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public ApplicationCommandDefinitionBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ApplicationCommandOptionBuilder();
        configure(builder);
        return AddOption(builder.Build());
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        return Set("DefaultMemberPermissions", new Optional<PermissionFlags?>(value));
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitDefaultMemberPermissions()
    {
        return Set("DefaultMemberPermissions", default(Optional<PermissionFlags?>));
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public ApplicationCommandDefinitionBuilder ClearDefaultMemberPermissions()
    {
        return WithDefaultMemberPermissions(null);
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithDmPermission(bool? value)
    {
        return Set("DmPermission", new Optional<bool?>(value));
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitDmPermission()
    {
        return Set("DmPermission", default(Optional<bool?>));
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithDefaultPermission(bool value)
    {
        return Set("DefaultPermission", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitDefaultPermission()
    {
        return Set("DefaultPermission", default(Optional<bool>));
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithNsfw(bool value)
    {
        return Set("Nsfw", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitNsfw()
    {
        return Set("Nsfw", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets IntegrationTypes; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        return Set("IntegrationTypes", new Optional<List<ApplicationIntegrationType>>(value));
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitIntegrationTypes()
    {
        return Set("IntegrationTypes", default(Optional<List<ApplicationIntegrationType>>));
    }

    /// <summary>
    ///     Appends IntegrationType.
    /// </summary>
    public ApplicationCommandDefinitionBuilder AddIntegrationType(ApplicationIntegrationType value)
    {
        return Add("IntegrationTypes", value);
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithContexts(List<InteractionContextType> value)
    {
        return Set("Contexts", new Optional<List<InteractionContextType>>(value));
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitContexts()
    {
        return Set("Contexts", default(Optional<List<InteractionContextType>>));
    }


    /// <summary>
    ///     Sets Handler; explicit defaults remain present.
    /// </summary>
    public ApplicationCommandDefinitionBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        return Set("Handler", new Optional<EntryPointCommandHandlerType>(value));
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public ApplicationCommandDefinitionBuilder OmitHandler()
    {
        return Set("Handler", default(Optional<EntryPointCommandHandlerType>));
    }
}