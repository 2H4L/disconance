namespace Disconance.Models.Guilds;

/// <summary>
///     Prompt Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object-prompt-types" />
public enum OnboardingPromptType
{
    /// <summary>
    ///     MULTIPLE_CHOICE
    /// </summary>
    MultipleChoice = 0,

    /// <summary>
    ///     DROPDOWN
    /// </summary>
    Dropdown = 1
}