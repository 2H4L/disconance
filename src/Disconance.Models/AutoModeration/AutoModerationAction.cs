namespace Disconance.Models.AutoModeration;

/// <summary>
///     Auto Moderation Action data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
public class AutoModerationAction
{
    /// <summary>
    ///     The type of action.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
    public required AutoModerationActionType Type { get; set; }

    /// <summary>
    ///     Additional metadata needed during execution for this specific action type.
    /// </summary>
    /// <remarks>Discord field: <c>metadata</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/auto-moderation#auto-moderation-action-object" />
    public Optional<AutoModerationActionMetadata> Metadata { get; set; }
}