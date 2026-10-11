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
///     Fluently builds CreateFollowupMessageRequest; mutable and not thread-safe.
/// </summary>
public sealed class CreateFollowupMessageRequestBuilder : IRequestBuilder<CreateFollowupMessageRequest>
{
    private readonly Snowflake _applicationId;
    private readonly List<DiscordFile> _files = [];
    private readonly string _interactionToken;
    private readonly CreateFollowupMessageBodyBuilder _payload = new();
    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal CreateFollowupMessageRequestBuilder(Snowflake applicationId, string interactionToken,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _interactionToken = interactionToken;
    }

    /// <inheritdoc />
    public CreateFollowupMessageRequest Build()
    {
        return new CreateFollowupMessageRequest(_applicationId, _interactionToken, _payload.Build())
        {
            AuditLogReason = _auditReason,
            Files = _files.ToArray()
        };
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithContent(string value)
    {
        _payload.WithContent(value);
        return this;
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitContent()
    {
        _payload.OmitContent();
        return this;
    }

    /// <summary>
    ///     Sets Tts; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithTts(bool value)
    {
        _payload.WithTts(value);
        return this;
    }

    /// <summary>
    ///     Omits Tts.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitTts()
    {
        _payload.OmitTts();
        return this;
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithEmbeds(List<Embed> value)
    {
        _payload.WithEmbeds(value);
        return this;
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitEmbeds()
    {
        _payload.OmitEmbeds();
        return this;
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddEmbed(Embed value)
    {
        _payload.AddEmbed(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        _payload.AddEmbed(configure);
        return this;
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithAllowedMentions(AllowedMentions value)
    {
        _payload.WithAllowedMentions(value);
        return this;
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitAllowedMentions()
    {
        _payload.OmitAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        _payload.WithAllowedMentions(configure);
        return this;
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithComponents(List<Component> value)
    {
        _payload.WithComponents(value);
        return this;
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitComponents()
    {
        _payload.OmitComponents();
        return this;
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddComponent(Component value)
    {
        _payload.AddComponent(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        _payload.AddActionRow(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddButton(Action<ButtonBuilder> configure)
    {
        _payload.AddButton(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        _payload.AddChannelSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        _payload.AddCheckbox(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        _payload.AddCheckboxGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        _payload.AddContainer(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        _payload.AddFile(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        _payload.AddFileUpload(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        _payload.AddLabel(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        _payload.AddMediaGallery(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        _payload.AddMentionableSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        _payload.AddRadioGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        _payload.AddRoleSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddSection(Action<SectionBuilder> configure)
    {
        _payload.AddSection(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        _payload.AddSeparator(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        _payload.AddStringSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        _payload.AddTextDisplay(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        _payload.AddTextInput(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        _payload.AddThumbnail(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        _payload.AddUserSelect(configure);
        return this;
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithAttachments(List<PartialAttachment> value)
    {
        _payload.WithAttachments(value);
        return this;
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitAttachments()
    {
        _payload.OmitAttachments();
        return this;
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddAttachment(PartialAttachment value)
    {
        _payload.AddAttachment(value);
        return this;
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithFlags(MessageFlags value)
    {
        _payload.WithFlags(value);
        return this;
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitFlags()
    {
        _payload.OmitFlags();
        return this;
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithPoll(PollDefinition value)
    {
        _payload.WithPoll(value);
        return this;
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public CreateFollowupMessageRequestBuilder OmitPoll()
    {
        _payload.OmitPoll();
        return this;
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        _payload.WithPoll(configure);
        return this;
    }

    /// <summary>
    ///     Adds a replayable upload. Supported only by Discord's message and callback endpoints.
    /// </summary>
    public CreateFollowupMessageRequestBuilder AddFile(DiscordFile file)
    {
        _files.Add(file);
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public CreateFollowupMessageRequestBuilder WithAuditLogReason(string? reason)
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