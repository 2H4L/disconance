namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Dynamic Field Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
public enum DynamicFieldType
{
    /// <summary>
    ///     A text value.
    /// </summary>
    String = 1,

    /// <summary>
    ///     A numeric value.
    /// </summary>
    Number = 2,

    /// <summary>
    ///     A media object (image URL).
    /// </summary>
    Media = 3
}