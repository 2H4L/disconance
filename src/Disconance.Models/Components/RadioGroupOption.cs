namespace Disconance.Models.Components;

/// <summary>
///     Radio Group Option data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-option-structure" />
public class RadioGroupOption
{
    /// <summary>
    ///     Dev-defined value of the option; max 100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>value</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-option-structure" />
    public required string Value { get; set; }

    /// <summary>
    ///     User-facing label of the option; max 100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>label</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-option-structure" />
    public required string Label { get; set; }

    /// <summary>
    ///     Optional description for the option; max 100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-option-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Shows the option as selected by default.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>default</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#radio-group-option-structure" />
    public Optional<bool> Default { get; set; }
}