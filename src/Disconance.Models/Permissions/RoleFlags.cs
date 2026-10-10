namespace Disconance.Models.Permissions;

/// <summary>
///     Role Flags defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-flags" />
[Flags]
public enum RoleFlags : ulong
{
    /// <summary>
    ///     No flags are set.
    /// </summary>
    None = 0,

    /// <summary>
    ///     Role can be selected by members in an onboarding prompt.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    InPrompt = 1UL << 0
}