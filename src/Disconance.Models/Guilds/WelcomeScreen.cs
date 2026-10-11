namespace Disconance.Models.Guilds;

/// <summary>
///     Welcome Screen data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#welcome-screen-object-welcome-screen-structure" />
public class WelcomeScreen
{
    /// <summary>
    ///     The server description shown in the welcome screen.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#welcome-screen-object-welcome-screen-structure" />
    public required string? Description { get; set; }

    /// <summary>
    ///     The channels shown in the welcome screen, up to 5.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>welcome_channels</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#welcome-screen-object-welcome-screen-structure" />
    public required List<WelcomeScreenChannel> WelcomeChannels { get; set; }
}