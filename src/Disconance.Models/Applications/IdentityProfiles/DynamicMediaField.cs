namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Dynamic Media Field data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
public class DynamicMediaField : DynamicField
{
    /// <summary>
    ///     <c>3</c> , identifies a media field.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public override DynamicFieldType Type => DynamicFieldType.Media;

    /// <summary>
    ///     The media value.
    /// </summary>
    /// <remarks>Discord field: <c>value</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
    public required Media Value { get; set; }
}