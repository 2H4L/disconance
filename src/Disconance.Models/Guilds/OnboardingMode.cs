namespace Disconance.Models.Guilds;

/// <summary>
///     Onboarding Mode defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object-onboarding-mode" />
public enum OnboardingMode
{
    /// <summary>
    ///     Counts only Default Channels towards constraints.
    /// </summary>
    OnboardingDefault = 0,

    /// <summary>
    ///     Counts Default Channels and Questions towards constraints.
    /// </summary>
    OnboardingAdvanced = 1
}