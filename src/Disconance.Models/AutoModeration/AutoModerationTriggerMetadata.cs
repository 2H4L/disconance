namespace Disconance.Models.AutoModeration;

/// <summary>
///     Trigger Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
public class AutoModerationTriggerMetadata
{
    /// <summary>
    ///     Substrings which will be searched for in content (Maximum of 1000).
    /// </summary>
    /// <remarks>Discord field: <c>keyword_filter</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<List<string>> KeywordFilter { get; set; }

    /// <summary>
    ///     Regular expression patterns which will be matched against content (Maximum of 10).
    /// </summary>
    /// <remarks>Discord field: <c>regex_patterns</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<List<string>> RegexPatterns { get; set; }

    /// <summary>
    ///     The internally pre-defined wordsets which will be searched for in content.
    /// </summary>
    /// <remarks>Discord field: <c>presets</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<List<AutoModerationKeywordPresetType>> Presets { get; set; }

    /// <summary>
    ///     Substrings which should not trigger the rule (Maximum of 100 or 1000).
    /// </summary>
    /// <remarks>Discord field: <c>allow_list</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<List<string>> AllowList { get; set; }

    /// <summary>
    ///     Total number of unique role and user mentions allowed per message (Maximum of 50).
    /// </summary>
    /// <remarks>Discord field: <c>mention_total_limit</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<int> MentionTotalLimit { get; set; }

    /// <summary>
    ///     Whether to automatically detect mention raids.
    /// </summary>
    /// <remarks>Discord field: <c>mention_raid_protection_enabled</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object" />
    public Optional<bool> MentionRaidProtectionEnabled { get; set; }
}