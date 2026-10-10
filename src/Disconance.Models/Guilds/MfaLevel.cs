namespace Disconance.Models.Guilds;

/// <summary>
///     MFA Level defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-object-mfa-level" />
public enum MfaLevel
{
    /// <summary>
    ///     Guild has no MFA/2FA requirement for moderation actions.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Guild has a 2FA requirement for moderation actions.
    /// </summary>
    Elevated = 1
}