namespace Disconance.Models.AutoModeration;

/// <summary>
///     Keyword Preset Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
public enum AutoModerationKeywordPresetType
{
    /// <summary>
    ///     Words that may be considered forms of swearing or cursing.
    /// </summary>
    Profanity = 1,

    /// <summary>
    ///     Words that refer to sexually explicit behavior or activity.
    /// </summary>
    SexualContent = 2,

    /// <summary>
    ///     Personal insults or words that may be considered hate speech.
    /// </summary>
    Slurs = 3
}