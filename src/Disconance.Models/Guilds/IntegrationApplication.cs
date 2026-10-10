using Disconance.Models.Users;

namespace Disconance.Models.Guilds;

/// <summary>
///     Integration Application data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
public class IntegrationApplication
{
    /// <summary>
    ///     The id of the app.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     The name of the app.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     The icon hash of the app.
    /// </summary>
    /// <remarks>Discord field: <c>icon</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Icon { get; set; }

    /// <summary>
    ///     The description of the app.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
    public required string Description { get; set; }

    /// <summary>
    ///     The bot associated with this application.
    /// </summary>
    /// <remarks>Discord field: <c>bot</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-application-object" />
    public Optional<User> Bot { get; set; }
}