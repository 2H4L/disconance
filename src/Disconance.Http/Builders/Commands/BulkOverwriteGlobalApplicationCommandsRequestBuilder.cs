using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds BulkOverwriteGlobalApplicationCommandsRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    BulkOverwriteGlobalApplicationCommandsRequestBuilder : IRequestBuilder<
    BulkOverwriteGlobalApplicationCommandsRequest>
{
    private readonly Snowflake _applicationId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;
    private List<ApplicationCommandDefinition> _commands = [];

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal BulkOverwriteGlobalApplicationCommandsRequestBuilder(Snowflake applicationId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
    }

    /// <inheritdoc />
    public BulkOverwriteGlobalApplicationCommandsRequest Build()
    {
        return new BulkOverwriteGlobalApplicationCommandsRequest(_applicationId, ModelSnapshot.Copy(_commands))
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Replaces the command definitions; an empty list explicitly removes all commands in this scope.
    /// </summary>
    public BulkOverwriteGlobalApplicationCommandsRequestBuilder WithCommands(
        IEnumerable<ApplicationCommandDefinition> commands)
    {
        _commands = [.. commands];
        return this;
    }

    /// <summary>
    ///     Appends a command definition.
    /// </summary>
    public BulkOverwriteGlobalApplicationCommandsRequestBuilder AddCommand(ApplicationCommandDefinition command)
    {
        _commands.Add(command);
        return this;
    }

    /// <summary>
    ///     Composes and appends a command definition.
    /// </summary>
    public BulkOverwriteGlobalApplicationCommandsRequestBuilder AddCommand(
        Action<ApplicationCommandDefinitionBuilder> configure)
    {
        var builder = new ApplicationCommandDefinitionBuilder();
        configure(builder);
        return AddCommand(builder.Build());
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public BulkOverwriteGlobalApplicationCommandsRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<List<ApplicationCommand>>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}