using Disconance.Http.Builders.Commands;

namespace Disconance.Interactions.Commands;

/// <summary>
///     A discoverable top-level slash command containing subcommands or subcommand groups.
/// </summary>
public abstract class CommandGroup : CommandGroupBase
{
    /// <summary>
    ///     Configures the group's name, description, permissions, and contexts.
    ///     Chat-input type and child options are supplied by the framework.
    /// </summary>
    public abstract void Configure(ApplicationCommandDefinitionBuilder group);
}