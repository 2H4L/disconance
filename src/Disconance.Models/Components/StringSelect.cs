namespace Disconance.Models.Components;

/// <summary>
///     String Select data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
public class StringSelect : Component
{
    /// <summary>
    ///     <c>3</c> for string select.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public override ComponentType Type => ComponentType.StringSelect;

    /// <summary>
    ///     ID for the select menu; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Specified choices in a select menu; max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>options</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public required List<SelectOption> Options { get; set; }

    /// <summary>
    ///     Placeholder text if nothing is selected or default; max 150 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     Minimum number of items that must be chosen (defaults to 1); min 0 (see note), max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_values</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public Optional<int> MinValues { get; set; }

    /// <summary>
    ///     Maximum number of items that can be chosen (defaults to 1); max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_values</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public Optional<int> MaxValues { get; set; }

    /// <summary>
    ///     Whether the string select is required to answer in a modal (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     Whether select menu is disabled in a message (defaults to <c>false</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>disabled</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-string-select-structure" />
    public Optional<bool> Disabled { get; set; }
}