using Disconance.Models.Applications;
using Disconance.Models.Channels;
using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Polls;
using Disconance.Models.Stickers;
using Disconance.Models.Users;

namespace Disconance.Models.Messages;

/// <summary>
///     A partial Message resource. Each field may be absent; consult the source context for the supplied subset.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
public class PartialMessage
{
    /// <summary>
    ///     Id of the message.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     Id of the channel the message was sent in.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<Snowflake> ChannelId { get; set; }

    /// <summary>
    ///     The author of this message (not guaranteed to be a valid user, see below).
    /// </summary>
    /// <remarks>Discord field: <c>author</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<User> Author { get; set; }

    /// <summary>
    ///     Contents of the message.
    /// </summary>
    /// <remarks>Discord field: <c>content</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<string> Content { get; set; }

    /// <summary>
    ///     When this message was sent.
    /// </summary>
    /// <remarks>Discord field: <c>timestamp</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<DateTimeOffset> Timestamp { get; set; }

    /// <summary>
    ///     When this message was edited (or null if never).
    /// </summary>
    /// <remarks>Discord field: <c>edited_timestamp</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<DateTimeOffset?> EditedTimestamp { get; set; }

    /// <summary>
    ///     Whether this was a TTS message.
    /// </summary>
    /// <remarks>Discord field: <c>tts</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<bool> Tts { get; set; }

    /// <summary>
    ///     Whether this message mentions everyone.
    /// </summary>
    /// <remarks>Discord field: <c>mention_everyone</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<bool> MentionEveryone { get; set; }

    /// <summary>
    ///     Users specifically mentioned in the message.
    /// </summary>
    /// <remarks>Discord field: <c>mentions</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<User>> Mentions { get; set; }

    /// <summary>
    ///     Roles specifically mentioned in this message.
    /// </summary>
    /// <remarks>Discord field: <c>mention_roles</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Snowflake>> MentionRoles { get; set; }

    /// <summary>
    ///     Channels specifically mentioned in this message.
    /// </summary>
    /// <remarks>Discord field: <c>mention_channels</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<ChannelMention>> MentionChannels { get; set; }

    /// <summary>
    ///     Any attached files that are not referenced in embeds or components.
    /// </summary>
    /// <remarks>Discord field: <c>attachments</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Attachment>> Attachments { get; set; }

    /// <summary>
    ///     Any embedded content.
    /// </summary>
    /// <remarks>Discord field: <c>embeds</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Embed>> Embeds { get; set; }

    /// <summary>
    ///     Reactions to the message.
    /// </summary>
    /// <remarks>Discord field: <c>reactions</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Reaction>> Reactions { get; set; }

    /// <summary>
    ///     Used for validating a message was sent.
    /// </summary>
    /// <remarks>Discord field: <c>nonce</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<MessageNonce> Nonce { get; set; }

    /// <summary>
    ///     Whether this message is pinned.
    /// </summary>
    /// <remarks>Discord field: <c>pinned</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<bool> Pinned { get; set; }

    /// <summary>
    ///     If the message is generated by a webhook, this is the webhook's id.
    /// </summary>
    /// <remarks>Discord field: <c>webhook_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<Snowflake> WebhookId { get; set; }

    /// <summary>
    ///     Type of message.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<MessageType> Type { get; set; }

    /// <summary>
    ///     Sent with Rich Presence-related chat embeds.
    /// </summary>
    /// <remarks>Discord field: <c>activity</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<MessageActivity> Activity { get; set; }

    /// <summary>
    ///     Sent with Rich Presence-related chat embeds.
    /// </summary>
    /// <remarks>Discord field: <c>application</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<PartialApplication> Application { get; set; }

    /// <summary>
    ///     If the message is an Interaction or application-owned webhook, this is the id of the application.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<Snowflake> ApplicationId { get; set; }

    /// <summary>
    ///     Message flags combined as a bitfield.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<MessageFlags> Flags { get; set; }

    /// <summary>
    ///     Data showing the source of a crosspost, channel follow add, pin, or reply message.
    /// </summary>
    /// <remarks>Discord field: <c>message_reference</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<MessageReference> MessageReference { get; set; }

    /// <summary>
    ///     The message associated with the <c>message_reference</c> . This is a minimal subset of fields in a message
    ///     (e.g. <c>author</c> is excluded.)
    /// </summary>
    /// <remarks>Discord field: <c>message_snapshots</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<MessageSnapshot>> MessageSnapshots { get; set; }

    /// <summary>
    ///     The message associated with the message_reference.
    /// </summary>
    /// <remarks>Discord field: <c>referenced_message</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<Message?> ReferencedMessage { get; set; }

    /// <summary>
    ///     Sent if the message is sent as a result of an interaction.
    /// </summary>
    /// <remarks>Discord field: <c>interaction_metadata</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<MessageInteractionMetadata> InteractionMetadata { get; set; }

    /// <summary>
    ///     Deprecated in favor of <c>interaction_metadata</c> ; sent if the message is a response to an interaction.
    /// </summary>
    /// <remarks>Discord field: <c>interaction</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding" />
    public Optional<MessageInteraction> Interaction { get; set; }

    /// <summary>
    ///     The thread that was started from this message, includes thread member object.
    /// </summary>
    /// <remarks>Discord field: <c>thread</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/channel#thread-member-object" />
    public Optional<Channel> Thread { get; set; }

    /// <summary>
    ///     Sent if the message contains components like buttons, action rows, or other interactive components.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Component>> Components { get; set; }

    /// <summary>
    ///     Sent if the message contains stickers.
    /// </summary>
    /// <remarks>Discord field: <c>sticker_items</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<StickerItem>> StickerItems { get; set; }

    /// <summary>
    ///     Deprecated the stickers sent with the message.
    /// </summary>
    /// <remarks>Discord field: <c>stickers</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<List<Sticker>> Stickers { get; set; }

    /// <summary>
    ///     A generally increasing integer (there may be gaps or duplicates) that represents the approximate position of
    ///     the message in a thread, it can be used to estimate the relative position of the message in a thread in
    ///     company with <c>total_message_sent</c> on parent thread.
    /// </summary>
    /// <remarks>Discord field: <c>position</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<int> Position { get; set; }

    /// <summary>
    ///     Data of the role subscription purchase or renewal that prompted this ROLE_SUBSCRIPTION_PURCHASE message.
    /// </summary>
    /// <remarks>Discord field: <c>role_subscription_data</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<RoleSubscriptionData> RoleSubscriptionData { get; set; }

    /// <summary>
    ///     Data for users, members, channels, and roles referenced in this message.
    /// </summary>
    /// <remarks>Discord field: <c>resolved</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<ResolvedData> Resolved { get; set; }

    /// <summary>
    ///     A poll.
    /// </summary>
    /// <remarks>Discord field: <c>poll</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<Poll> Poll { get; set; }

    /// <summary>
    ///     The call associated with the message.
    /// </summary>
    /// <remarks>Discord field: <c>call</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<MessageCall> Call { get; set; }

    /// <summary>
    ///     The custom client-side theme shared via the message.
    /// </summary>
    /// <remarks>Discord field: <c>shared_client_theme</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
    public Optional<SharedClientTheme> SharedClientTheme { get; set; }
}