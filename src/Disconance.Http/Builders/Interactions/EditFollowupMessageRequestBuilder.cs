using Disconance.Http.Builders.Components;
using Disconance.Http.Builders.Messages;
using Disconance.Http.Builders.Polls;
using Disconance.Http.Requests.Interactions;
using Disconance.Http.Responses;
using Disconance.Http.Uploads;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently builds EditFollowupMessageRequest; mutable and not thread-safe.
/// </summary>
public sealed class EditFollowupMessageRequestBuilder : IRequestBuilder<EditFollowupMessageRequest>
{
    private readonly Snowflake _applicationId;
    private readonly List<DiscordFile> _files = [];
    private readonly string _interactionToken;
    private readonly Snowflake _messageId;
    private readonly EditInteractionMessageBodyBuilder _payload = new();

    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal EditFollowupMessageRequestBuilder(Snowflake applicationId, string interactionToken, Snowflake messageId,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _interactionToken = interactionToken;
        _messageId = messageId;
    }

    /// <inheritdoc />
    public EditFollowupMessageRequest Build()
    {
        return new EditFollowupMessageRequest(_applicationId, _interactionToken, _messageId, _payload.Build())
        {
            AuditLogReason = _auditReason,
            Files = _files.ToArray()
        };
    }

    /// <summary>
    ///     Sends explicit null for Embeds.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearEmbeds()
    {
        return WithEmbeds(null);
    }

    /// <summary>
    ///     Sends explicit null for Components.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearComponents()
    {
        return WithComponents(null);
    }

    /// <summary>
    ///     Sends explicit null for Attachments.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearAttachments()
    {
        return WithAttachments(null);
    }

    /// <summary>
    ///     Sends explicit null for Flags.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearFlags()
    {
        return WithFlags(null);
    }

    /// <summary>
    ///     Sends explicit null for Poll.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearPoll()
    {
        return WithPoll((PollDefinition?)null);
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithContent(string? value)
    {
        _payload.WithContent(value);
        return this;
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitContent()
    {
        _payload.OmitContent();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for Content.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearContent()
    {
        _payload.ClearContent();
        return this;
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithEmbeds(List<Embed>? value)
    {
        _payload.WithEmbeds(value);
        return this;
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitEmbeds()
    {
        _payload.OmitEmbeds();
        return this;
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddEmbed(Embed value)
    {
        _payload.AddEmbed(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        _payload.AddEmbed(configure);
        return this;
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithAllowedMentions(AllowedMentions? value)
    {
        _payload.WithAllowedMentions(value);
        return this;
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitAllowedMentions()
    {
        _payload.OmitAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for AllowedMentions.
    /// </summary>
    public EditFollowupMessageRequestBuilder ClearAllowedMentions()
    {
        _payload.ClearAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        _payload.WithAllowedMentions(configure);
        return this;
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithComponents(List<Component>? value)
    {
        _payload.WithComponents(value);
        return this;
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitComponents()
    {
        _payload.OmitComponents();
        return this;
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddComponent(Component value)
    {
        _payload.AddComponent(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        _payload.AddActionRow(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddButton(Action<ButtonBuilder> configure)
    {
        _payload.AddButton(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        _payload.AddChannelSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        _payload.AddCheckbox(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        _payload.AddCheckboxGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        _payload.AddContainer(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        _payload.AddFile(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        _payload.AddFileUpload(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        _payload.AddLabel(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        _payload.AddMediaGallery(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        _payload.AddMentionableSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        _payload.AddRadioGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        _payload.AddRoleSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddSection(Action<SectionBuilder> configure)
    {
        _payload.AddSection(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        _payload.AddSeparator(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        _payload.AddStringSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        _payload.AddTextDisplay(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        _payload.AddTextInput(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        _payload.AddThumbnail(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        _payload.AddUserSelect(configure);
        return this;
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithAttachments(List<PartialAttachment>? value)
    {
        _payload.WithAttachments(value);
        return this;
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitAttachments()
    {
        _payload.OmitAttachments();
        return this;
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddAttachment(PartialAttachment value)
    {
        _payload.AddAttachment(value);
        return this;
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithFlags(MessageFlags? value)
    {
        _payload.WithFlags(value);
        return this;
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitFlags()
    {
        _payload.OmitFlags();
        return this;
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithPoll(PollDefinition? value)
    {
        _payload.WithPoll(value);
        return this;
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public EditFollowupMessageRequestBuilder OmitPoll()
    {
        _payload.OmitPoll();
        return this;
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        _payload.WithPoll(configure);
        return this;
    }

    /// <summary>
    ///     Adds a replayable upload. Supported only by Discord's message and callback endpoints.
    /// </summary>
    public EditFollowupMessageRequestBuilder AddFile(DiscordFile file)
    {
        _files.Add(file);
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public EditFollowupMessageRequestBuilder WithAuditLogReason(string? reason)
    {
        _auditReason = reason;
        return this;
    }

    /// <summary>
    ///     Builds and sends the request through the bound sender.
    /// </summary>
    public Task<DiscordResponse<Message>> SendAsync(CancellationToken cancellationToken = default)
    {
        return _sender.SendAsync(Build(), cancellationToken);
    }
}