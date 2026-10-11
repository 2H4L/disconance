namespace Disconance.Models.Components;

/// <summary>
///     Mentionable Select data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
public class MentionableSelect : Component
{
    /// <summary>
    ///     <c>7</c> for mentionable select.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public override ComponentType Type => ComponentType.MentionableSelect;

    /// <summary>
    ///     ID for the select menu; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Placeholder text if nothing is selected; max 150 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     List of default values for auto-populated select menu components; number of default values must be in the
    ///     range defined by <c>min_values</c> and <c>max_values</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default_values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<List<SelectDefaultValue>> DefaultValues { get; set; }

    /// <summary>
    ///     Minimum number of items that must be chosen (defaults to 1); min 0 (see note), max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<int> MinValues { get; set; }

    /// <summary>
    ///     Maximum number of items that can be chosen (defaults to 1); max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_values</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<int> MaxValues { get; set; }

    /// <summary>
    ///     Whether the mentionable select is required to answer in a modal (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     Whether select menu is disabled in a message (defaults to <c>false</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>disabled</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#mentionable-select" />
    public Optional<bool> Disabled { get; set; }
}