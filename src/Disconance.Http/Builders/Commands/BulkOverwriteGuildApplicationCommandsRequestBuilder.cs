using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders.Commands;

/// <summary>
///     Fluently builds BulkOverwriteGuildApplicationCommandsRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    BulkOverwriteGuildApplicationCommandsRequestBuilder : IRequestBuilder<BulkOverwriteGuildApplicationCommandsRequest>
{
    private readonly Snowflake _applicationId;
    private readonly Snowflake _guildId;
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;
    private List<ApplicationCommandDefinition> _commands = [];

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal BulkOverwriteGuildApplicationCommandsRequestBuilder(Snowflake applicationId, Snowflake guildId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _guildId = guildId;
    }

    /// <inheritdoc />
    public BulkOverwriteGuildApplicationCommandsRequest Build()
    {
        return new BulkOverwriteGuildApplicationCommandsRequest(_applicationId, _guildId, ModelSnapshot.Copy(_commands))
        {
            AuditLogReason = _auditReason
        };
    }

    /// <summary>
    ///     Replaces the command definitions; an empty list explicitly removes all commands in this scope.
    /// </summary>
    public BulkOverwriteGuildApplicationCommandsRequestBuilder WithCommands(
        IEnumerable<ApplicationCommandDefinition> commands)
    {
        _commands = [.. commands];
        return this;
    }

    /// <summary>
    ///     Appends a command definition.
    /// </summary>
    public BulkOverwriteGuildApplicationCommandsRequestBuilder AddCommand(ApplicationCommandDefinition command)
    {
        _commands.Add(command);
        return this;
    }

    /// <summary>
    ///     Composes and appends a command definition.
    /// </summary>
    public BulkOverwriteGuildApplicationCommandsRequestBuilder AddCommand(
        Action<ApplicationCommandDefinitionBuilder> configure)
    {
        var builder = new ApplicationCommandDefinitionBuilder();
        configure(builder);
        return AddCommand(builder.Build());
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public BulkOverwriteGuildApplicationCommandsRequestBuilder WithAuditLogReason(string? reason)
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