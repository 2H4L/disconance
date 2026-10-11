using Disconance.Http.Builders.Interactions;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Interaction followup operations.
/// </summary>
public sealed class FollowupMessagesScope(IDiscordRequestSender sender, Snowflake applicationId, string token)
{
    /// <summary>
    ///     Creates a followup.
    /// </summary>
    public CreateFollowupMessageRequestBuilder Create()
    {
        return new CreateFollowupMessageRequestBuilder(applicationId, token, sender);
    }

    /// <summary>
    ///     Gets a followup.
    /// </summary>
    public GetFollowupMessageRequestBuilder Get(Snowflake messageId)
    {
        return new GetFollowupMessageRequestBuilder(applicationId, token, messageId, sender);
    }

    /// <summary>
    ///     Edits a followup.
    /// </summary>
    public EditFollowupMessageRequestBuilder Edit(Snowflake messageId)
    {
        return new EditFollowupMessageRequestBuilder(applicationId, token, messageId, sender);
    }

    /// <summary>
    ///     Deletes a followup.
    /// </summary>
    public DeleteFollowupMessageRequestBuilder Delete(Snowflake messageId)
    {
        return new DeleteFollowupMessageRequestBuilder(applicationId, token, messageId, sender);
    }
}