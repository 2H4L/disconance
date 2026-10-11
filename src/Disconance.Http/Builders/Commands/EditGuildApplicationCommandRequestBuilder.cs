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
///     Fluently builds EditGuildApplicationCommandRequest; mutable and not thread-safe.
/// </summary>
public sealed class EditGuildApplicationCommandRequestBuilder : IRequestBuilder<EditGuildApplicationCommandRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _commandId;
    private readonly Snowflake _guildId;
    private readonly EditApplicationCommandBodyBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal EditGuildApplicationCommandRequestBuilder(Snowflake applicationId, Snowflake guildId, Snowflake commandId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _guildId = guildId;
        _commandId = commandId;
    }

    /// <inheritdoc />
    public EditGuildApplicationCommandRequest Build()
    {
        return new EditGuildApplicationCommandRequest(_applicationId, _guildId, _commandId, _payload.Build())
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Sets IntegrationTypes; applicable to global commands.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithIntegrationTypes(List<ApplicationIntegrationType> value)
    {
        _payload.WithIntegrationTypes(value);
        return this;
    }

    /// <summary>
    ///     Omits IntegrationTypes.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitIntegrationTypes()
    {
        _payload.OmitIntegrationTypes();
        return this;
    }

    /// <summary>
    ///     Sets Handler; applicable to global commands.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithHandler(EntryPointCommandHandlerType value)
    {
        _payload.WithHandler(value);
        return this;
    }

    /// <summary>
    ///     Omits Handler.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitHandler()
    {
        _payload.OmitHandler();
        return this;
    }

    /// <summary>
    ///     Sets Name; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithName(string value)
    {
        _payload.WithName(value);
        return this;
    }

    /// <summary>
    ///     Omits Name.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitName()
    {
        _payload.OmitName();
        return this;
    }

    /// <summary>
    ///     Sets NameLocalizations; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithNameLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithNameLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits NameLocalizations.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitNameLocalizations()
    {
        _payload.OmitNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for NameLocalizations.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder ClearNameLocalizations()
    {
        _payload.ClearNameLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Description; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithDescription(string value)
    {
        _payload.WithDescription(value);
        return this;
    }

    /// <summary>
    ///     Omits Description.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitDescription()
    {
        _payload.OmitDescription();
        return this;
    }

    /// <summary>
    ///     Sets DescriptionLocalizations; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithDescriptionLocalizations(Dictionary<string, string>? value)
    {
        _payload.WithDescriptionLocalizations(value);
        return this;
    }

    /// <summary>
    ///     Omits DescriptionLocalizations.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitDescriptionLocalizations()
    {
        _payload.OmitDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DescriptionLocalizations.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder ClearDescriptionLocalizations()
    {
        _payload.ClearDescriptionLocalizations();
        return this;
    }

    /// <summary>
    ///     Sets Options; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithOptions(List<ApplicationCommandOption> value)
    {
        _payload.WithOptions(value);
        return this;
    }

    /// <summary>
    ///     Omits Options.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitOptions()
    {
        _payload.OmitOptions();
        return this;
    }

    /// <summary>
    ///     Appends Option.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder AddOption(ApplicationCommandOption value)
    {
        _payload.AddOption(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ApplicationCommandOption.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder AddOption(Action<ApplicationCommandOptionBuilder> configure)
    {
        _payload.AddOption(configure);
        return this;
    }

    /// <summary>
    ///     Sets DefaultMemberPermissions; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithDefaultMemberPermissions(PermissionFlags? value)
    {
        _payload.WithDefaultMemberPermissions(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultMemberPermissions.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitDefaultMemberPermissions()
    {
        _payload.OmitDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for DefaultMemberPermissions.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder ClearDefaultMemberPermissions()
    {
        _payload.ClearDefaultMemberPermissions();
        return this;
    }

    /// <summary>
    ///     Sets DmPermission; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithDmPermission(bool? value)
    {
        _payload.WithDmPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DmPermission.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitDmPermission()
    {
        _payload.OmitDmPermission();
        return this;
    }

    /// <summary>
    ///     Sets DefaultPermission; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithDefaultPermission(bool value)
    {
        _payload.WithDefaultPermission(value);
        return this;
    }

    /// <summary>
    ///     Omits DefaultPermission.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitDefaultPermission()
    {
        _payload.OmitDefaultPermission();
        return this;
    }


    /// <summary>
    ///     Sets Nsfw; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithNsfw(bool value)
    {
        _payload.WithNsfw(value);
        return this;
    }

    /// <summary>
    ///     Omits Nsfw.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitNsfw()
    {
        _payload.OmitNsfw();
        return this;
    }

    /// <summary>
    ///     Sets Contexts; explicit defaults remain present.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithContexts(List<InteractionContextType> value)
    {
        _payload.WithContexts(value);
        return this;
    }

    /// <summary>
    ///     Omits Contexts.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder OmitContexts()
    {
        _payload.OmitContexts();
        return this;
    }


    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder WithAuditLogReason(string? reason)
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