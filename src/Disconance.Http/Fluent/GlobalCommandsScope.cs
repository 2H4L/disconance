using Disconance.Http.Builders.Commands;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Global application command operations.
/// </summary>
public sealed class GlobalCommandsScope(IDiscordRequestSender sender, Snowflake applicationId)
{
    /// <summary>
    ///     List commands in this scope.
    /// </summary>
    public GetGlobalApplicationCommandsRequestBuilder List()
    {
        return new GetGlobalApplicationCommandsRequestBuilder(applicationId, sender);
    }

    /// <summary>
    ///     Get commands in this scope.
    /// </summary>
    public GetGlobalApplicationCommandRequestBuilder Get(Snowflake commandId)
    {
        return new GetGlobalApplicationCommandRequestBuilder(applicationId, commandId, sender);
    }

    /// <summary>
    ///     Create commands in this scope.
    /// </summary>
    public CreateGlobalApplicationCommandRequestBuilder Create()
    {
        return new CreateGlobalApplicationCommandRequestBuilder(applicationId, sender);
    }

    /// <summary>
    ///     Edit commands in this scope.
    /// </summary>
    public EditGlobalApplicationCommandRequestBuilder Edit(Snowflake commandId)
    {
        return new EditGlobalApplicationCommandRequestBuilder(applicationId, commandId, sender);
    }

    /// <summary>
    ///     Delete commands in this scope.
    /// </summary>
    public DeleteGlobalApplicationCommandRequestBuilder Delete(Snowflake commandId)
    {
        return new DeleteGlobalApplicationCommandRequestBuilder(applicationId, commandId, sender);
    }

    /// <summary>
    ///     BulkOverwrite commands in this scope; replaces the entire command set.
    /// </summary>
    public BulkOverwriteGlobalApplicationCommandsRequestBuilder BulkOverwrite()
    {
        return new BulkOverwriteGlobalApplicationCommandsRequestBuilder(applicationId, sender);
    }
}