namespace Disconance.Models.Users;

/// <summary>
///     Visibility Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-visibility-types" />
public enum ConnectionVisibilityType
{
    /// <summary>
    ///     Invisible to everyone except the user themselves.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Visible to everyone.
    /// </summary>
    Everyone = 1
}