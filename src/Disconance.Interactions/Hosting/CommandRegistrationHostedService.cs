using Disconance.Interactions.Commands;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Disconance.Interactions.Hosting;

internal sealed class CommandRegistrationHostedService(
    IServiceScopeFactory scopeFactory,
    IOptions<DiscordInteractionOptions> options,
    IEnumerable<CommandRegistrationTarget> targets) : IHostedLifecycleService
{
    private readonly CommandRegistrationTarget[] _targets = targets.Distinct().ToArray();

    public async Task StartingAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var targets = _targets.Select(target =>
            (ApplicationId: target.ApplicationId ?? options.Value.ApplicationId, GuildId: target.GuildId))
            .Distinct().ToArray();

        if (targets.Any(target => target.ApplicationId.Value == 0))
        {
            throw new OptionsValidationException(Options.DefaultName, typeof(DiscordInteractionOptions),
                ["ApplicationId must be configured for startup command registration without an explicit application ID."]);
        }

        await using var scope = scopeFactory.CreateAsyncScope();
        var registration = scope.ServiceProvider.GetRequiredService<ICommandRegistrationService>();

        foreach (var target in targets)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (target.GuildId is { } guildId)
            {
                await registration.RegisterGuildCommandsAsync(target.ApplicationId, guildId, cancellationToken);
            }
            else
            {
                await registration.RegisterGlobalCommandsAsync(target.ApplicationId, cancellationToken);
            }
        }
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StartedAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppingAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StoppedAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
