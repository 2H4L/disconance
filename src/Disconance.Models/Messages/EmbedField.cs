namespace Disconance.Models.Messages;

/// <summary>
///     Embed Field data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-field-structure" />
public class EmbedField
{
    /// <summary>
    ///     Name of the field.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-field-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Value of the field.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-field-structure" />
    public required string Value { get; set; }

    /// <summary>
    ///     Whether or not this field should display inline.
    /// </summary>
    /// <remarks>Discord field: <c>inline</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-field-structure" />
    public Optional<bool> Inline { get; set; }
}