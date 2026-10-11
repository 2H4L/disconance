using Disconance.Http.Builders.Users;
using Disconance.Models;

namespace Disconance.Http.Fluent;

/// <summary>
///     Optional fluent entry points available on any sender implementation.
/// </summary>
public static class DiscordRequestExtensions
{
    extension(IDiscordRequestSender sender)
    {
        /// <summary>
        ///     Selects a channel.
        /// </summary>
        public ChannelScope Channel(Snowflake channelId)
        {
            return new ChannelScope(sender, channelId);
        }

        /// <summary>
        ///     Selects an application for command registration.
        /// </summary>
        public ApplicationScope Application(Snowflake applicationId)
        {
            return new ApplicationScope(sender, applicationId);
        }

        /// <summary>
        ///     Selects an interaction for its initial callback.
        /// </summary>
        public InteractionScope Interaction(Snowflake interactionId, string token)
        {
            return new InteractionScope(sender, interactionId, token);
        }

        /// <summary>
        ///     Selects a token-authenticated interaction webhook for original responses and followups.
        /// </summary>
        public InteractionWebhookScope InteractionWebhook(Snowflake applicationId,
            string token)
        {
            return new InteractionWebhookScope(sender, applicationId, token);
        }

        /// <summary>
        ///     Builds the current-user request.
        /// </summary>
        public GetCurrentUserRequestBuilder CurrentUser()
        {
            return new GetCurrentUserRequestBuilder(sender);
        }
    }
}