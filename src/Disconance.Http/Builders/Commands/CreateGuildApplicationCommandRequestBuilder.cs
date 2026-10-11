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
///     Fluently builds CreateGuildApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class CreateGuildApplicationCommandRequestBuilder : IRequestBuilder<CreateGuildApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _guildId;
    private readonly ApplicationCommandDefinitionBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal CreateGuildApplicationCommandRequestBuilder(Snowflake applicationId, Snowflake guildId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _guildId = guildId;
    }

    /// <inheritdoc />
    public CreateGuildApplicationCommandRequest Build()
    {
        return new CreateGuildApplicationCommandRequest(_applicationId, _guildId, _payload.Build())
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithName(string value)
    {
        _payload.WithName(value);
        return this;
    }

    /// <summary>
    ///     Sets Type; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithType(ApplicationCommandType value)
    {
        _payload.WithType(value);
        return this;
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithNameLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitNameLocalizations()
    {
        _payload.OmitNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder ClearNameLocalizations()
    {
        _payload.ClearNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithDescription(string value)
    {
        _payload.WithDescription(value);
        return this;
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitDescription()
    {
        _payload.OmitDescription();
        return this;
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithDescriptionLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitDescriptionLocalizations()
    {
        _payload.OmitDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder ClearDescriptionLocalizations()
    {
        _payload.ClearDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        _payload.WithOptions(value);
        return this;
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitOptions()
    {
        _payload.OmitOptions();
        return this;
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder AddOption(ApplicationCommandOption value)
    {
        _payload.AddOption(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        _payload.AddOption(configure);
        return this;
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        _payload.WithDefaultMemberPermissions(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitDefaultMemberPermissions()
    {
        _payload.OmitDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder ClearDefaultMemberPermissions()
    {
        _payload.ClearDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithDmPermission(bool? value)
    {
        _payload.WithDmPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitDmPermission()
    {
        _payload.OmitDmPermission();
        return this;
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithDefaultPermission(bool value)
    {
        _payload.WithDefaultPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitDefaultPermission()
    {
        _payload.OmitDefaultPermission();
        return this;
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithNsfw(bool value)
    {
        _payload.WithNsfw(value);
        return this;
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitNsfw()
    {
        _payload.OmitNsfw();
        return this;
    }

    /// <summary>
    ///     Sets IntegrationTypes; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        _payload.WithIntegrationTypes(value);
        return this;
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitIntegrationTypes()
    {
        _payload.OmitIntegrationTypes();
        return this;
    }

    /// <summary>
    ///     Appends IntegrationType.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder AddIntegrationType(ApplicationIntegrationType value)
    {
        _payload.AddIntegrationType(value);
        return this;
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithContexts(List<InteractionContextType> value)
    {
        _payload.WithContexts(value);
        return this;
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitContexts()
    {
        _payload.OmitContexts();
        return this;
    }


    /// <summary>
    ///     Sets Handler; explicit defaults remain present.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        _payload.WithHandler(value);
        return this;
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder OmitHandler()
    {
        _payload.OmitHandler();
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
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