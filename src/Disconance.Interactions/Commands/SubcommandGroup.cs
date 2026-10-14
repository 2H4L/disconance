using Disconance.Http.Builders.Interactions.Commands;

namespace Disconance.Interactions.Commands;

/// <summary>
///     A nested group of subcommands. Derive from the generic form to identify its parent.
/// </summary>
public abstract class SubcommandGroup : CommandGroupBase
{
    internal SubcommandGroup()
    {
    }

    internal abstract Type ParentType { get; }

    /// <summary>
    ///     Configures the group's name, description, and localizations.
    ///     The framework supplies its type and children.
    /// </summary>
    public abstract void Configure(ApplicationCommandOptionBuilder group);
}

/// <summary>
///     A discoverable subcommand group belonging to a specific top-level group.
/// </summary>
/// <typeparam name="TGroup">
///     The parent top-level command group.
/// </typeparam>
public abstract class SubcommandGroup<TGroup> : SubcommandGroup where TGroup : CommandGroup
{
    internal sealed override Type ParentType => typeof(TGroup);
}