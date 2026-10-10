namespace Disconance.Models.Guilds;

/// <summary>
///     Onboarding Prompt data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
public class OnboardingPrompt
{
    /// <summary>
    ///     ID of the prompt.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of prompt.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required OnboardingPromptType Type { get; set; }

    /// <summary>
    ///     Options available within the prompt.
    /// </summary>
    /// <remarks>Discord field: <c>options</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required List<PromptOption> Options { get; set; }

    /// <summary>
    ///     Title of the prompt.
    /// </summary>
    /// <remarks>Discord field: <c>title</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required string Title { get; set; }

    /// <summary>
    ///     Indicates whether users are limited to selecting one option for the prompt.
    /// </summary>
    /// <remarks>Discord field: <c>single_select</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required bool SingleSelect { get; set; }

    /// <summary>
    ///     Indicates whether the prompt is required before a user completes the onboarding flow.
    /// </summary>
    /// <remarks>Discord field: <c>required</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required bool Required { get; set; }

    /// <summary>
    ///     Indicates whether the prompt is present in the onboarding flow. If <c>false</c> , the prompt will only
    ///     appear in the Channels &amp; Roles tab.
    /// </summary>
    /// <remarks>Discord field: <c>in_onboarding</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required bool InOnboarding { get; set; }
}