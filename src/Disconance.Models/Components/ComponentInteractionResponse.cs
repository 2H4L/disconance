namespace Disconance.Models.Components;

/// <summary>
///     Submitted component data, distinct from a component's display configuration.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public abstract class ComponentInteractionResponse
{
    /// <summary>
    ///     The kind of submitted component.
    /// </summary>
    public abstract ComponentType Type { get; }

    /// <summary>
    ///     The component's numeric identifier; this is not a snowflake or custom ID.
    /// </summary>
    public required int Id { get; set; }
}