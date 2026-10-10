namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     A named game statistic whose concrete type determines the value format.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile#dynamic-field-object" />
public abstract class DynamicField
{
    /// <summary>
    ///     The value format of this statistic.
    /// </summary>
    public abstract DynamicFieldType Type { get; }

    /// <summary>
    ///     The data key referenced by the widget configuration.
    /// </summary>
    public required string Name { get; set; }
}