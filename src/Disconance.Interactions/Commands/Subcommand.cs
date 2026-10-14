using Disconance.Http.Builders.Interactions.Commands;

namespace Disconance.Interactions.Commands;

/// <summary>
///     A grouped slash command. Derive from the generic form to identify its parent.
/// </summary>
public abstract class Subcommand : CommandHandler
{
    internal Subcommand()
    {
    }

    internal abstract Type ParentType { get; }

    /// <summary>
    ///     Configures the subcommand's name, description, localizations, and parameters.
    ///     The framework supplies its subcommand type.
    /// </summary>
    public abstract void Configure(ApplicationCommandOptionBuilder command);
}

/// <summary>
///     A discoverable subcommand belonging to a top-level group or a subcommand group.
/// </summary>
/// <typeparam name="TGroup">
///     The parent command group.
/// </typeparam>
public abstract class Subcommand<TGroup> : Subcommand where TGroup : CommandGroupBase
{
    internal sealed override Type ParentType => typeof(TGroup);
}