namespace Disconance.Models.AutoModeration;

/// <summary>
///     Action Types defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
public enum AutoModerationActionType
{
    /// <summary>
    ///     Blocks a member's message and prevents it from being posted. A custom explanation can be specified and shown
    ///     to members whenever their message is blocked.
    /// </summary>
    BlockMessage = 1,

    /// <summary>
    ///     Logs user content to a specified channel.
    /// </summary>
    SendAlertMessage = 2,

    /// <summary>
    ///     Timeout user for a specified duration.
    /// </summary>
    Timeout = 3,

    /// <summary>
    ///     Prevents a member from using text, voice, or other interactions.
    /// </summary>
    BlockMemberInteraction = 4
}