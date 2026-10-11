using Disconance.Http.Builders.Commands;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Guild application command operations.
/// </summary>
public sealed class GuildCommandsScope(IDiscordRequestSender sender, Snowflake applicationId, Snowflake guildId)
{
    /// <summary>
    ///     List commands in this scope.
    /// </summary>
    public GetGuildApplicationCommandsRequestBuilder List()
    {
        return new GetGuildApplicationCommandsRequestBuilder(applicationId, guildId, sender);
    }

    /// <summary>
    ///     Get commands in this scope.
    /// </summary>
    public GetGuildApplicationCommandRequestBuilder Get(Snowflake commandId)
    {
        return new GetGuildApplicationCommandRequestBuilder(applicationId, guildId, commandId, sender);
    }

    /// <summary>
    ///     Create commands in this scope.
    /// </summary>
    public CreateGuildApplicationCommandRequestBuilder Create()
    {
        return new CreateGuildApplicationCommandRequestBuilder(applicationId, guildId, sender);
    }

    /// <summary>
    ///     Edit commands in this scope.
    /// </summary>
    public EditGuildApplicationCommandRequestBuilder Edit(Snowflake commandId)
    {
        return new EditGuildApplicationCommandRequestBuilder(applicationId, guildId, commandId, sender);
    }

    /// <summary>
    ///     Delete commands in this scope.
    /// </summary>
    public DeleteGuildApplicationCommandRequestBuilder Delete(Snowflake commandId)
    {
        return new DeleteGuildApplicationCommandRequestBuilder(applicationId, guildId, commandId, sender);
    }

    /// <summary>
    ///     BulkOverwrite commands in this scope; replaces the entire command set.
    /// </summary>
    public BulkOverwriteGuildApplicationCommandsRequestBuilder BulkOverwrite()
    {
        return new BulkOverwriteGuildApplicationCommandsRequestBuilder(applicationId, guildId, sender);
    }
}