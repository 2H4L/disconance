using Disconance.Models.Users;

namespace Disconance.Models.Guilds;

/// <summary>
///     A widget's anonymized partial user with presence and a public avatar URL.
/// </summary>
/// <remarks>
///     The identifier, discriminator, and avatar are anonymized by Discord. Do not use them as account identifiers.
/// </remarks>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-widget-object" />
public class GuildWidgetUser : PartialUser
{
    /// <summary>
    ///     The user's presence status in the widget.
    /// </summary>
    public Optional<string> Status { get; set; }

    /// <summary>
    ///     The anonymized widget avatar URL.
    /// </summary>
    public Optional<string> AvatarUrl { get; set; }
}