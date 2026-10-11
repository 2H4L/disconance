namespace Disconance.Models.Components;

/// <summary>
///     Text Input data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
public class TextInput : Component
{
    /// <summary>
    ///     <c>4</c> for a text input.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public override ComponentType Type => ComponentType.TextInput;

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>custom_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     The Text Input Style.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>style</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public required TextInputStyle Style { get; set; }

    /// <summary>
    ///     Minimum input length for a text input; min 0, max 4000.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_length</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public Optional<int> MinLength { get; set; }

    /// <summary>
    ///     Maximum input length for a text input; min 1, max 4000.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_length</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public Optional<int> MaxLength { get; set; }

    /// <summary>
    ///     Whether this component is required to be filled (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     Pre-filled value for this component; max 4000 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>value</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public Optional<string> Value { get; set; }

    /// <summary>
    ///     Custom placeholder text if the input is empty; max 100 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>placeholder</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#text-input-text-input-structure" />
    public Optional<string> Placeholder { get; set; }
}