using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Commands;

internal sealed class CommandNode(CommandHandler? handler = null)
{
    internal CommandHandler? Handler { get; } = handler;

    internal Dictionary<string, (ApplicationCommandOption Option, CommandNode Node)> Children { get; } =
        new(StringComparer.Ordinal);
}
