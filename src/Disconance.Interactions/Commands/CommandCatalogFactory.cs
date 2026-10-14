using Disconance.Http.Builders.Commands;
using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Commands;

internal sealed class CommandCatalogFactory
{
    private readonly Dictionary<(ApplicationCommandType Type, string Name), CommandNode> _roots = [];
    private readonly List<ApplicationCommandDefinition> _definitions = [];
    private readonly Dictionary<Type, CommandNode> _groupNodes = [];
    private readonly List<(ApplicationCommandDefinition Definition, CommandNode Node)> _rootGroups = [];
    private readonly List<(SubcommandGroup Group, ApplicationCommandOption Option, CommandNode Node)> _nestedGroups = [];

    internal (IReadOnlyList<ApplicationCommandDefinition> Definitions,
        IReadOnlyDictionary<(ApplicationCommandType Type, string Name), CommandNode> Roots) Create(IEnumerable<Command> commands, IEnumerable<CommandGroupBase> groups,
        IEnumerable<Subcommand> subcommands)
    {
        AddCommands(commands);
        AddGroups(groups);
        AddChildren(subcommands);
        CompleteGroups();
        return (_definitions.AsReadOnly(), _roots);
    }

    private void AddCommands(IEnumerable<Command> commands)
    {
        foreach (var command in commands)
        {
            var builder = new ApplicationCommandDefinitionBuilder().WithType(ApplicationCommandType.ChatInput);
            command.Configure(builder);
            var definition = builder.Build();
            ValidateParameters(definition.Options.GetValueOrDefault([]));
            AddRoot(definition, new CommandNode(command));
            _definitions.Add(definition);
        }
    }

    private void AddGroups(IEnumerable<CommandGroupBase> groups)
    {
        foreach (var group in groups)
        {
            var node = new CommandNode();

            if (!_groupNodes.TryAdd(group.GetType(), node))
            {
                throw new InvalidOperationException($"Group {group.GetType().Name} is registered more than once.");
            }

            switch (group)
            {
                case CommandGroup root:
                    AddRootGroup(root, node);
                    break;
                case SubcommandGroup nested:
                    AddNestedGroup(nested, node);
                    break;
            }
        }
    }

    private void AddRootGroup(CommandGroup group, CommandNode node)
    {
        var builder = new ApplicationCommandDefinitionBuilder().WithType(ApplicationCommandType.ChatInput);
        group.Configure(builder);
        var definition = builder.Build();

        if (definition.Type != ApplicationCommandType.ChatInput || definition.Options.HasValue)
        {
            throw new InvalidOperationException("Command groups use chat-input type and discovered children.");
        }

        AddRoot(definition, node);
        _definitions.Add(definition);
        _rootGroups.Add((definition, node));
    }

    private void AddNestedGroup(SubcommandGroup group, CommandNode node)
    {
        var builder = new ApplicationCommandOptionBuilder().WithType(ApplicationCommandOptionType.SubCommandGroup);
        group.Configure(builder);
        var option = builder.Build();
        ValidateGroupOption(option, ApplicationCommandOptionType.SubCommandGroup);

        if (option.Options.HasValue)
        {
            throw new InvalidOperationException("Subcommand groups use discovered children.");
        }

        _nestedGroups.Add((group, option, node));
    }

    private void AddChildren(IEnumerable<Subcommand> subcommands)
    {
        foreach (var (group, option, node) in _nestedGroups)
        {
            AddChild(group.ParentType, option, node);
        }

        foreach (var command in subcommands)
        {
            var builder = new ApplicationCommandOptionBuilder().WithType(ApplicationCommandOptionType.SubCommand);
            command.Configure(builder);
            var option = builder.Build();
            ValidateGroupOption(option, ApplicationCommandOptionType.SubCommand);
            ValidateParameters(option.Options.GetValueOrDefault([]));
            AddChild(command.ParentType, option, new CommandNode(command));
        }
    }

    private void CompleteGroups()
    {
        foreach (var (_, option, node) in _nestedGroups)
        {
            option.Options = Children(node);
        }

        foreach (var (definition, node) in _rootGroups)
        {
            definition.Options = Children(node);
        }
    }

    private void AddChild(Type parent, ApplicationCommandOption option, CommandNode child)
    {
        if (!_groupNodes.TryGetValue(parent, out var node))
        {
            throw new InvalidOperationException($"Parent group {parent.Name} is not registered.");
        }

        if (!node.Children.TryAdd(option.Name, (option, child)))
        {
            throw new InvalidOperationException($"Duplicate command '{option.Name}' in group {parent.Name}.");
        }
    }

    private void AddRoot(ApplicationCommandDefinition definition, CommandNode node)
    {
        if (string.IsNullOrWhiteSpace(definition.Name) ||
            definition.Type is < ApplicationCommandType.ChatInput or > ApplicationCommandType.PrimaryEntryPoint)
        {
            throw new InvalidOperationException("Commands require a name and a supported application command type.");
        }

        if (!_roots.TryAdd((definition.Type, definition.Name), node))
        {
            throw new InvalidOperationException($"Duplicate {definition.Type} command '{definition.Name}'.");
        }
    }

    private static List<ApplicationCommandOption> Children(CommandNode node)
    {
        if (node.Children.Count is < 1 or > 25)
        {
            throw new InvalidOperationException("Groups require between one and 25 children.");
        }

        return node.Children.Values.Select(child => child.Option).ToList();
    }

    private static void ValidateGroupOption(ApplicationCommandOption option, ApplicationCommandOptionType type)
    {
        if (option.Type != type || string.IsNullOrWhiteSpace(option.Name) ||
            string.IsNullOrWhiteSpace(option.Description) || option.Required.HasValue ||
            option.Choices.HasValue || option.Autocomplete.HasValue)
        {
            throw new InvalidOperationException(
                "Groups and subcommands require their declared type, name, and description, without parameter-only fields.");
        }
    }

    private static void ValidateParameters(List<ApplicationCommandOption> options)
    {
        if (options.Count > 25 || options.Any(option =>
                option.Type is ApplicationCommandOptionType.SubCommand or ApplicationCommandOptionType.SubCommandGroup))
        {
            throw new InvalidOperationException(
                "Commands accept up to 25 parameters. Declare grouped commands as Subcommand<TGroup> classes.");
        }

        if (options.Select(option => option.Name).Distinct(StringComparer.Ordinal).Count() != options.Count)
        {
            throw new InvalidOperationException("Command parameter names must be unique.");
        }
    }
}
