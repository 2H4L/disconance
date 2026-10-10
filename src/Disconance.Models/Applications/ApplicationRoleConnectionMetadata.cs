namespace Disconance.Models.Applications;

/// <summary>
///     Application Role Connection Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
public class ApplicationRoleConnectionMetadata
{
    /// <summary>
    ///     Type of metadata value.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public required ApplicationRoleConnectionMetadataType Type { get; set; }

    /// <summary>
    ///     Dictionary key for the metadata field (must be <c>a-z</c> , <c>0-9</c> , or <c>_</c> characters; 1-50
    ///     characters).
    /// </summary>
    /// <remarks>Discord field: <c>key</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public required string Key { get; set; }

    /// <summary>
    ///     Name of the metadata field (1-100 characters).
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public required string Name { get; set; }

    /// <summary>
    ///     Translations of the name.
    /// </summary>
    /// <remarks>Discord field: <c>name_localizations</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public Optional<Dictionary<string, string>> NameLocalizations { get; set; }

    /// <summary>
    ///     Description of the metadata field (1-200 characters).
    /// </summary>
    /// <remarks>Discord field: <c>description</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public required string Description { get; set; }

    /// <summary>
    ///     Translations of the description.
    /// </summary>
    /// <remarks>Discord field: <c>description_localizations</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-role-connection-metadata" />
    public Optional<Dictionary<string, string>> DescriptionLocalizations { get; set; }
}