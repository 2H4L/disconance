using Disconance.Interactions.Commands;
using Disconance.Interactions.Components;
using Disconance.Interactions.Modals;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions;

internal sealed class DefaultInteractionHandler(
    CommandCatalog commands,
    IEnumerable<IMessageComponentHandler> components,
    IEnumerable<IModalSubmitHandler> modals) : IInteractionHandler
{
    public async Task<InteractionResponse?> HandleAsync(Interaction interaction,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(interaction);
        cancellationToken.ThrowIfCancellationRequested();

        switch (interaction.Type, interaction.Data.GetValueOrDefault(null!))
        {
            case (InteractionType.Ping, _):
                return new InteractionResponse { Type = InteractionCallbackType.Pong };
            case (InteractionType.ApplicationCommand or InteractionType.ApplicationCommandAutocomplete,
                ApplicationCommandData data):
            {
                var match = commands.Find(data);

                if (match is null || (interaction.Type == InteractionType.ApplicationCommandAutocomplete &&
                                      data.Type != ApplicationCommandType.ChatInput))
                {
                    return null;
                }

                var context = new CommandContext(interaction, data, match.Value.Options);

                return interaction.Type == InteractionType.ApplicationCommandAutocomplete
                    ? await match.Value.Handler.AutocompleteAsync(context, cancellationToken)
                    : await match.Value.Handler.ExecuteAsync(context, cancellationToken);
            }
            case (InteractionType.MessageComponent, MessageComponentData data):
            {
                var handler = Match(components, candidate => candidate.CanHandle(data.CustomId), data.CustomId);
                return handler is null ? null : await handler.ExecuteAsync(interaction, data, cancellationToken);
            }
            case (InteractionType.ModalSubmit, ModalSubmitData data):
            {
                var handler = Match(modals, candidate => candidate.CanHandle(data.CustomId), data.CustomId);
                return handler is null ? null : await handler.ExecuteAsync(interaction, data, cancellationToken);
            }
            default:
                return null;
        }
    }

    private static T? Match<T>(IEnumerable<T> handlers, Func<T, bool> predicate, string customId) where T : class
    {
        var matches = handlers.Where(predicate).Take(2).ToArray();

        if (matches.Length > 1)
        {
            throw new InvalidOperationException(
                $"Multiple {typeof(T).Name} registrations match custom ID '{customId}'.");
        }

        return matches.SingleOrDefault();
    }
}