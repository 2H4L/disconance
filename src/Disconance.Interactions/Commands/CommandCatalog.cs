using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Commands;

internal sealed class CommandCatalog
{
    private readonly IReadOnlyDictionary<(ApplicationCommandType Type, string Name), CommandNode> _roots;

    public CommandCatalog(IEnumerable<Command> commands, IEnumerable<CommandGroupBase> groups,
        IEnumerable<Subcommand> subcommands)
    {
        var catalog = new CommandCatalogFactory().Create(commands, groups, subcommands);
        Definitions = catalog.Definitions;
        _roots = catalog.Roots;
    }

    internal IReadOnlyList<ApplicationCommandDefinition> Definitions { get; }

    internal (CommandHandler Handler, IReadOnlyList<ApplicationCommandInteractionDataOption> Options)? Find(
        ApplicationCommandData data)
    {
        if (string.IsNullOrEmpty(data.Name) || !_roots.TryGetValue((data.Type, data.Name), out var node))
        {
            return null;
        }

        var options = NormalizeOptions(data.Options.GetValueOrDefault([]));

        while (node.Handler is null)
        {
            if (options.Count != 1)
            {
                return null;
            }

            var selected = options[0];
            var child = FindChild(node, selected);

            if (child is null)
            {
                return null;
            }

            node = child;
            options = NormalizeOptions(selected.Options.GetValueOrDefault([]));
        }

        if (options.Any(IsInvalidParameter))
        {
            return null;
        }

        return (node.Handler, options);
    }

    private static CommandNode? FindChild(CommandNode parent, ApplicationCommandInteractionDataOption? selected)
    {
        if (selected is null || string.IsNullOrEmpty(selected.Name) || selected.Value.HasValue ||
            !parent.Children.TryGetValue(selected.Name, out var child) || child.Option.Type != selected.Type)
        {
            return null;
        }

        return child.Node;
    }

    private static bool IsInvalidParameter(ApplicationCommandInteractionDataOption? option)
    {
        return option is null ||
               option.Type is ApplicationCommandOptionType.SubCommand or ApplicationCommandOptionType.SubCommandGroup;
    }

    private static IReadOnlyList<ApplicationCommandInteractionDataOption> NormalizeOptions(
        IReadOnlyList<ApplicationCommandInteractionDataOption>? options)
    {
        // Wire data can contain null despite the model's non-nullable contract.
        return options ?? [];
    }
}
