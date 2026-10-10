namespace Disconance.Models.AutoModeration;

/// <summary>
///     Event Types defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-rule-object-event-types" />
public enum AutoModerationEventType
{
    /// <summary>
    ///     When a member sends or edits a message in the guild.
    /// </summary>
    MessageSend = 1,

    /// <summary>
    ///     When a member edits their profile.
    /// </summary>
    MemberUpdate = 2
}