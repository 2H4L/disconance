namespace Disconance.Models.Components;

/// <summary>
///     Anatomy of a Component data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#anatomy-of-a-component" />
public abstract class Component
{
    /// <summary>
    ///     The type of the component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#anatomy-of-a-component" />
    public abstract ComponentType Type { get; }

    /// <summary>
    ///     32 bit integer used as an optional identifier for component.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#anatomy-of-a-component" />
    public Optional<int> Id { get; set; }
}