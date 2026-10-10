namespace Disconance.Models.AutoModeration;

/// <summary>
///     Trigger Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
public enum AutoModerationTriggerType
{
    /// <summary>
    ///     Check if content contains words from a user defined list of keywords.
    /// </summary>
    Keyword = 1,

    /// <summary>
    ///     Check if content represents generic spam.
    /// </summary>
    Spam = 3,

    /// <summary>
    ///     Check if content contains words from internal pre-defined wordsets.
    /// </summary>
    KeywordPreset = 4,

    /// <summary>
    ///     Check if content contains more unique mentions than allowed.
    /// </summary>
    MentionSpam = 5,

    /// <summary>
    ///     Check if member profile contains words from a user defined list of keywords.
    /// </summary>
    MemberProfile = 6
}