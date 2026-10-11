using Disconance.Http.Builders.Components;
using Disconance.Http.Requests.Messages;
using Disconance.Http.Responses;
using Disconance.Http.Uploads;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently builds EditMessageRequest; mutable and not thread-safe.
/// </summary>
public sealed class EditMessageRequestBuilder : IRequestBuilder<EditMessageRequest>
{
    private readonly Snowflake _channelId;
    private readonly List<DiscordFile> _files = [];
    private readonly Snowflake _messageId;
    private readonly EditMessageBodyBuilder _payload = new();

    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal EditMessageRequestBuilder(Snowflake channelId, Snowflake messageId, IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _channelId = channelId;
        _messageId = messageId;
    }

    /// <inheritdoc />
    public EditMessageRequest Build()
    {
        return new EditMessageRequest(_channelId, _messageId, _payload.Build())
        {
            AuditLogReason = _auditReason,
            Files = _files.ToArray()
        };
    }

    /// <summary>
    ///     Sends explicit null for Embeds.
    /// </summary>
    public EditMessageRequestBuilder ClearEmbeds()
    {
        return WithEmbeds(null);
    }

    /// <summary>
    ///     Sends explicit null for Components.
    /// </summary>
    public EditMessageRequestBuilder ClearComponents()
    {
        return WithComponents(null);
    }

    /// <summary>
    ///     Sends explicit null for Attachments.
    /// </summary>
    public EditMessageRequestBuilder ClearAttachments()
    {
        return WithAttachments(null);
    }

    /// <summary>
    ///     Sends explicit null for Flags.
    /// </summary>
    public EditMessageRequestBuilder ClearFlags()
    {
        return WithFlags(null);
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithContent(string? value)
    {
        _payload.WithContent(value);
        return this;
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public EditMessageRequestBuilder OmitContent()
    {
        _payload.OmitContent();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for Content.
    /// </summary>
    public EditMessageRequestBuilder ClearContent()
    {
        _payload.ClearContent();
        return this;
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithEmbeds(List<Embed>? value)
    {
        _payload.WithEmbeds(value);
        return this;
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public EditMessageRequestBuilder OmitEmbeds()
    {
        _payload.OmitEmbeds();
        return this;
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public EditMessageRequestBuilder AddEmbed(Embed value)
    {
        _payload.AddEmbed(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public EditMessageRequestBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        _payload.AddEmbed(configure);
        return this;
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithAllowedMentions(AllowedMentions? value)
    {
        _payload.WithAllowedMentions(value);
        return this;
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public EditMessageRequestBuilder OmitAllowedMentions()
    {
        _payload.OmitAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for AllowedMentions.
    /// </summary>
    public EditMessageRequestBuilder ClearAllowedMentions()
    {
        _payload.ClearAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public EditMessageRequestBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        _payload.WithAllowedMentions(configure);
        return this;
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithComponents(List<Component>? value)
    {
        _payload.WithComponents(value);
        return this;
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public EditMessageRequestBuilder OmitComponents()
    {
        _payload.OmitComponents();
        return this;
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public EditMessageRequestBuilder AddComponent(Component value)
    {
        _payload.AddComponent(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EditMessageRequestBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        _payload.AddActionRow(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EditMessageRequestBuilder AddButton(Action<ButtonBuilder> configure)
    {
        _payload.AddButton(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EditMessageRequestBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        _payload.AddChannelSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EditMessageRequestBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        _payload.AddCheckbox(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EditMessageRequestBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        _payload.AddCheckboxGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EditMessageRequestBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        _payload.AddContainer(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EditMessageRequestBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        _payload.AddFile(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EditMessageRequestBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        _payload.AddFileUpload(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EditMessageRequestBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        _payload.AddLabel(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EditMessageRequestBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        _payload.AddMediaGallery(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EditMessageRequestBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        _payload.AddMentionableSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EditMessageRequestBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        _payload.AddRadioGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EditMessageRequestBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        _payload.AddRoleSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EditMessageRequestBuilder AddSection(Action<SectionBuilder> configure)
    {
        _payload.AddSection(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EditMessageRequestBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        _payload.AddSeparator(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EditMessageRequestBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        _payload.AddStringSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EditMessageRequestBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        _payload.AddTextDisplay(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EditMessageRequestBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        _payload.AddTextInput(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EditMessageRequestBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        _payload.AddThumbnail(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EditMessageRequestBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        _payload.AddUserSelect(configure);
        return this;
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithAttachments(List<PartialAttachment>? value)
    {
        _payload.WithAttachments(value);
        return this;
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public EditMessageRequestBuilder OmitAttachments()
    {
        _payload.OmitAttachments();
        return this;
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public EditMessageRequestBuilder AddAttachment(PartialAttachment value)
    {
        _payload.AddAttachment(value);
        return this;
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public EditMessageRequestBuilder WithFlags(MessageFlags? value)
    {
        _payload.WithFlags(value);
        return this;
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public EditMessageRequestBuilder OmitFlags()
    {
        _payload.OmitFlags();
        return this;
    }

    /// <summary>
    ///     Adds a replayable upload. Supported only by Discord's message and callback endpoints.
    /// </summary>
    public EditMessageRequestBuilder AddFile(DiscordFile file)
    {
        _files.Add(file);
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public EditMessageRequestBuilder WithAuditLogReason(string? reason)
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