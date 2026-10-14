using Disconance.Http.Builders.Commands;

namespace Disconance.Interactions.Commands;

/// <summary>
///     A discoverable top-level slash, user, message, or primary entry-point command with scoped dependencies.
/// </summary>
public abstract class Command : CommandHandler
{
    /// <summary>
    ///     Configures the command's name, type, options, permissions, and contexts using the shared HTTP builder.
    ///     The default type is chat input. Configuration runs once per catalog scope and must be deterministic.
    /// </summary>
    public abstract void Configure(ApplicationCommandDefinitionBuilder command);
}