namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Dynamic Number Field data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
public class DynamicNumberField : DynamicField
{
    /// <summary>
    ///     <c>2</c> , identifies a number field.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public override DynamicFieldType Type => DynamicFieldType.Number;

    /// <summary>
    ///     The numeric value.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public required double Value { get; set; }
}