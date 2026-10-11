using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Applications;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Permissions;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds EditGlobalApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class EditGlobalApplicationCommandRequestBuilder : IRequestBuilder<EditGlobalApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _commandId;
    private readonly EditApplicationCommandBodyBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal EditGlobalApplicationCommandRequestBuilder(Snowflake applicationId, Snowflake commandId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _commandId = commandId;
    }

    /// <inheritdoc />
    public EditGlobalApplicationCommandRequest Build()
    {
        return new EditGlobalApplicationCommandRequest(_applicationId, _commandId, _payload.Build())
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets IntegrationTypes; applicable to global commands.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        _payload.WithIntegrationTypes(value);
        return this;
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitIntegrationTypes()
    {
        _payload.OmitIntegrationTypes();
        return this;
    }

    /// <summary>
    ///     Sets Handler; applicable to global commands.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        _payload.WithHandler(value);
        return this;
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitHandler()
    {
        _payload.OmitHandler();
        return this;
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithName(string value)
    {
        _payload.WithName(value);
        return this;
    }

    /// <summary>
    ///     Omits Name.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitName()
    {
        _payload.OmitName();
        return this;
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithNameLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitNameLocalizations()
    {
        _payload.OmitNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder ClearNameLocalizations()
    {
        _payload.ClearNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithDescription(string value)
    {
        _payload.WithDescription(value);
        return this;
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitDescription()
    {
        _payload.OmitDescription();
        return this;
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithDescriptionLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitDescriptionLocalizations()
    {
        _payload.OmitDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder ClearDescriptionLocalizations()
    {
        _payload.ClearDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        _payload.WithOptions(value);
        return this;
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitOptions()
    {
        _payload.OmitOptions();
        return this;
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder AddOption(ApplicationCommandOption value)
    {
        _payload.AddOption(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        _payload.AddOption(configure);
        return this;
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        _payload.WithDefaultMemberPermissions(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitDefaultMemberPermissions()
    {
        _payload.OmitDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder ClearDefaultMemberPermissions()
    {
        _payload.ClearDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithDmPermission(bool? value)
    {
        _payload.WithDmPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitDmPermission()
    {
        _payload.OmitDmPermission();
        return this;
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithDefaultPermission(bool value)
    {
        _payload.WithDefaultPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitDefaultPermission()
    {
        _payload.OmitDefaultPermission();
        return this;
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithNsfw(bool value)
    {
        _payload.WithNsfw(value);
        return this;
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitNsfw()
    {
        _payload.OmitNsfw();
        return this;
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithContexts(List<InteractionContextType> value)
    {
        _payload.WithContexts(value);
        return this;
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder OmitContexts()
    {
        _payload.OmitContexts();
        return this;
    }


    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<ApplicationCommand>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}