namespace Disconance.Models.Components;

/// <summary>
///     Checkbox data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-structure" />
public class Checkbox : Component
{
    /// <summary>
    ///     <c>23</c> for checkbox.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-structure" />
    public override ComponentType Type => ComponentType.Checkbox;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Whether the checkbox is selected by default.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-structure" />
    public Optional<bool> Default { get; set; }
}