namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Dynamic String Field data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
public class DynamicStringField : DynamicField
{
    /// <summary>
    ///     <c>1</c> , identifies a string field.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public override DynamicFieldType Type => DynamicFieldType.String;

    /// <summary>
    ///     The text value.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>value</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public required string Value { get; set; }
}