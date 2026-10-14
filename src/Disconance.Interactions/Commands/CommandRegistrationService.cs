using Disconance.Http;
using Disconance.Http.Requests.Commands;
using Disconance.Models;

namespace Disconance.Interactions.Commands;

internal sealed class CommandRegistrationService(CommandCatalog commands, IDiscordRequestSender sender)
    : ICommandRegistrationService
{
    public async Task RegisterGlobalCommandsAsync(Snowflake applicationId,
        CancellationToken cancellationToken = default)
    {
        ArgumentOutOfRangeException.ThrowIfZero(applicationId.Value);
        cancellationToken.ThrowIfCancellationRequested();

        foreach (var definition in commands.Definitions)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await sender.SendAsync(new CreateGlobalApplicationCommandRequest(applicationId, definition),
                cancellationToken);
        }
    }

    public async Task RegisterGuildCommandsAsync(Snowflake applicationId, Snowflake guildId,
        CancellationToken cancellationToken = default)
    {
        ArgumentOutOfRangeException.ThrowIfZero(applicationId.Value);
        ArgumentOutOfRangeException.ThrowIfZero(guildId.Value);
        cancellationToken.ThrowIfCancellationRequested();

        foreach (var definition in commands.Definitions)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await sender.SendAsync(new CreateGuildApplicationCommandRequest(applicationId, guildId, definition),
                cancellationToken);
        }
    }
}