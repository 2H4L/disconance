using Disconance.Models.Emojis;

namespace Disconance.Models.Components;

/// <summary>
///     Select Option data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
public class SelectOption
{
    /// <summary>
    ///     User-facing name of the option; max 100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>label</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
    public required string Label { get; set; }

    /// <summary>
    ///     Dev-defined value of the option; max 100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
    public required string Value { get; set; }

    /// <summary>
    ///     Additional description of the option; max 100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     <c>id</c> , <c>name</c> , and <c>animated</c> .
    /// </summary>
    /// <remarks>Discord field: <c>emoji</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
    public Optional<PartialEmoji> Emoji { get; set; }

    /// <summary>
    ///     Will show this option as selected by default.
    /// </summary>
    /// <remarks>Discord field: <c>default</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#string-select-select-option-structure" />
    public Optional<bool> Default { get; set; }
}