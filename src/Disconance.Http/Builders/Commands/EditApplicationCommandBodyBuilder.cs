using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Http.Requests.Commands;
using Disconance.Models;
using Disconance.Models.Applications;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Permissions;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Composes a EditApplicationCommandBody payload independently of transport.
/// </summary>
public sealed class
    EditApplicationCommandBodyBuilder : ModelBuilder<EditApplicationCommandBody, EditApplicationCommandBodyBuilder>
{
    /// <summary>
    ///     Sets IntegrationTypes; applicable to global commands.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        return Set("IntegrationTypes", new Optional<List<ApplicationIntegrationType>>(value));
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitIntegrationTypes()
    {
        return Set("IntegrationTypes", default(Optional<List<ApplicationIntegrationType>>));
    }

    /// <summary>
    ///     Sets Handler; applicable to global commands.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        return Set("Handler", new Optional<EntryPointCommandHandlerType>(value));
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitHandler()
    {
        return Set("Handler", default(Optional<EntryPointCommandHandlerType>));
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithName(string value)
    {
        return Set("Name", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Name.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitName()
    {
        return Set("Name", default(Optional<string>));
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        return Set("NameLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitNameLocalizations()
    {
        return Set("NameLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public EditApplicationCommandBodyBuilder ClearNameLocalizations()
    {
        return WithNameLocalizations(null);
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        return Set("DescriptionLocalizations", new Optional<Dictionary<string, string>?>(value));
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitDescriptionLocalizations()
    {
        return Set("DescriptionLocalizations", default(Optional<Dictionary<string, string>?>));
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public EditApplicationCommandBodyBuilder ClearDescriptionLocalizations()
    {
        return WithDescriptionLocalizations(null);
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        return Set("Options", new Optional<List<ApplicationCommandOption>>(value));
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitOptions()
    {
        return Set("Options", default(Optional<List<ApplicationCommandOption>>));
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public EditApplicationCommandBodyBuilder AddOption(ApplicationCommandOption value)
    {
        return Add("Options", value);
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public EditApplicationCommandBodyBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ApplicationCommandOptionBuilder();
        configure(builder);
        return AddOption(builder.Build());
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        return Set("DefaultMemberPermissions", new Optional<PermissionFlags?>(value));
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitDefaultMemberPermissions()
    {
        return Set("DefaultMemberPermissions", default(Optional<PermissionFlags?>));
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public EditApplicationCommandBodyBuilder ClearDefaultMemberPermissions()
    {
        return WithDefaultMemberPermissions(null);
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithDmPermission(bool? value)
    {
        return Set("DmPermission", new Optional<bool?>(value));
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitDmPermission()
    {
        return Set("DmPermission", default(Optional<bool?>));
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithDefaultPermission(bool value)
    {
        return Set("DefaultPermission", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitDefaultPermission()
    {
        return Set("DefaultPermission", default(Optional<bool>));
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithNsfw(bool value)
    {
        return Set("Nsfw", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitNsfw()
    {
        return Set("Nsfw", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public EditApplicationCommandBodyBuilder WithContexts(List<InteractionContextType> value)
    {
        return Set("Contexts", new Optional<List<InteractionContextType>>(value));
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public EditApplicationCommandBodyBuilder OmitContexts()
    {
        return Set("Contexts", default(Optional<List<InteractionContextType>>));
    }
}