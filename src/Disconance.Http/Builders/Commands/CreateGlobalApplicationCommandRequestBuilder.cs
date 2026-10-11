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
///     Fluently builds CreateGlobalApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    CreateGlobalApplicationCommandRequestBuilder : IRequestBuilder<CreateGlobalApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly ApplicationCommandDefinitionBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal CreateGlobalApplicationCommandRequestBuilder(Snowflake applicationId, IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
    }

    /// <inheritdoc />
    public CreateGlobalApplicationCommandRequest Build()
    {
        return new CreateGlobalApplicationCommandRequest(_applicationId, _payload.Build())
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithName(string value)
    {
        _payload.WithName(value);
        return this;
    }

    /// <summary>
    ///     Sets Type; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithType(ApplicationCommandType value)
    {
        _payload.WithType(value);
        return this;
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithNameLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitNameLocalizations()
    {
        _payload.OmitNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder ClearNameLocalizations()
    {
        _payload.ClearNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithDescription(string value)
    {
        _payload.WithDescription(value);
        return this;
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitDescription()
    {
        _payload.OmitDescription();
        return this;
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithDescriptionLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitDescriptionLocalizations()
    {
        _payload.OmitDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder ClearDescriptionLocalizations()
    {
        _payload.ClearDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        _payload.WithOptions(value);
        return this;
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitOptions()
    {
        _payload.OmitOptions();
        return this;
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder AddOption(ApplicationCommandOption value)
    {
        _payload.AddOption(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        _payload.AddOption(configure);
        return this;
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        _payload.WithDefaultMemberPermissions(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitDefaultMemberPermissions()
    {
        _payload.OmitDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder ClearDefaultMemberPermissions()
    {
        _payload.ClearDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithDmPermission(bool? value)
    {
        _payload.WithDmPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitDmPermission()
    {
        _payload.OmitDmPermission();
        return this;
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithDefaultPermission(bool value)
    {
        _payload.WithDefaultPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitDefaultPermission()
    {
        _payload.OmitDefaultPermission();
        return this;
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithNsfw(bool value)
    {
        _payload.WithNsfw(value);
        return this;
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitNsfw()
    {
        _payload.OmitNsfw();
        return this;
    }

    /// <summary>
    ///     Sets IntegrationTypes; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        _payload.WithIntegrationTypes(value);
        return this;
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitIntegrationTypes()
    {
        _payload.OmitIntegrationTypes();
        return this;
    }

    /// <summary>
    ///     Appends IntegrationType.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder AddIntegrationType(ApplicationIntegrationType value)
    {
        _payload.AddIntegrationType(value);
        return this;
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithContexts(List<InteractionContextType> value)
    {
        _payload.WithContexts(value);
        return this;
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitContexts()
    {
        _payload.OmitContexts();
        return this;
    }


    /// <summary>
    ///     Sets Handler; explicit defaults remain present.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        _payload.WithHandler(value);
        return this;
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder OmitHandler()
    {
        _payload.OmitHandler();
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
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