namespace Disconance.Models.Components;

/// <summary>
///     Checkbox Group data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
public class CheckboxGroup : Component
{
    /// <summary>
    ///     <c>22</c> for checkbox group.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public override ComponentType Type => ComponentType.CheckboxGroup;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     List of options to show; min 1, max 10.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>options</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public required List<CheckboxGroupOption> Options { get; set; }

    /// <summary>
    ///     Minimum number of items that must be chosen; min 0, max 10 (defaults to 1).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public Optional<int> MinValues { get; set; }

    /// <summary>
    ///     Maximum number of items that can be chosen; min 1, max 10 (defaults to the number of options).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public Optional<int> MaxValues { get; set; }

    /// <summary>
    ///     Whether selecting within the group is required (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#checkbox-group-structure" />
    public Optional<bool> Required { get; set; }
}