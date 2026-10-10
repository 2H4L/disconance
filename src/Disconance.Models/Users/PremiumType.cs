namespace Disconance.Models.Users;

/// <summary>
///     Premium Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#user-object-premium-types" />
public enum PremiumType
{
    /// <summary>
    ///     None
    /// </summary>
    None = 0,

    /// <summary>
    ///     Nitro Classic
    /// </summary>
    NitroClassic = 1,

    /// <summary>
    ///     Nitro
    /// </summary>
    Nitro = 2,

    /// <summary>
    ///     Nitro Basic
    /// </summary>
    NitroBasic = 3
}