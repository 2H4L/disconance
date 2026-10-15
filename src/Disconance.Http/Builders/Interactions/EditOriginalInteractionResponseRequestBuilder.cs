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
///     Fluently builds EditOriginalInteractionResponseRequest; mutable and not thread-safe.
/// </summary>
public sealed class
    EditOriginalInteractionResponseRequestBuilder : IRequestBuilder<EditOriginalInteractionResponseRequest>
{
    private readonly Snowflake _applicationId;
    private readonly List<DiscordFile> _files = [];
    private readonly string _interactionToken;
    private readonly EditInteractionMessageBodyBuilder _payload = new();

    private readonly IDiscordRequestSender _sender;
    private string? _auditReason;

    /// <summary>
    ///     Creates a builder bound to the sender that selected this endpoint.
    /// </summary>
    internal EditOriginalInteractionResponseRequestBuilder(Snowflake applicationId, string interactionToken,
        IDiscordRequestSender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
        _applicationId = applicationId;
        _interactionToken = interactionToken;
    }

    /// <inheritdoc />
    public EditOriginalInteractionResponseRequest Build()
    {
        return new EditOriginalInteractionResponseRequest(_applicationId, _interactionToken, _payload.Build())
        {
            AuditLogReason = _auditReason,
            Files = _files.ToArray()
        };
    }

    /// <summary>
    ///     Sends explicit null for Embeds.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearEmbeds()
    {
        return WithEmbeds(null);
    }

    /// <summary>
    ///     Sends explicit null for Components.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearComponents()
    {
        return WithComponents(null);
    }

    /// <summary>
    ///     Sends explicit null for Attachments.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearAttachments()
    {
        return WithAttachments(null);
    }

    /// <summary>
    ///     Sends explicit null for Flags.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearFlags()
    {
        return WithFlags(null);
    }

    /// <summary>
    ///     Sends explicit null for Poll.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearPoll()
    {
        return WithPoll((PollDefinition?) null);
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithContent(string? value)
    {
        _payload.WithContent(value);
        return this;
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitContent()
    {
        _payload.OmitContent();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for Content.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearContent()
    {
        _payload.ClearContent();
        return this;
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithEmbeds(List<Embed>? value)
    {
        _payload.WithEmbeds(value);
        return this;
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitEmbeds()
    {
        _payload.OmitEmbeds();
        return this;
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddEmbed(Embed value)
    {
        _payload.AddEmbed(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        _payload.AddEmbed(configure);
        return this;
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithAllowedMentions(AllowedMentions? value)
    {
        _payload.WithAllowedMentions(value);
        return this;
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitAllowedMentions()
    {
        _payload.OmitAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Sends an explicit null for AllowedMentions.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder ClearAllowedMentions()
    {
        _payload.ClearAllowedMentions();
        return this;
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        _payload.WithAllowedMentions(configure);
        return this;
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithComponents(List<Component>? value)
    {
        _payload.WithComponents(value);
        return this;
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitComponents()
    {
        _payload.OmitComponents();
        return this;
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddComponent(Component value)
    {
        _payload.AddComponent(value);
        return this;
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        _payload.AddActionRow(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddButton(Action<ButtonBuilder> configure)
    {
        _payload.AddButton(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        _payload.AddChannelSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        _payload.AddCheckbox(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        _payload.AddCheckboxGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        _payload.AddContainer(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        _payload.AddFile(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        _payload.AddFileUpload(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        _payload.AddLabel(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        _payload.AddMediaGallery(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddMentionableSelect(
        Action<MentionableSelectBuilder> configure)
    {
        _payload.AddMentionableSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        _payload.AddRadioGroup(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        _payload.AddRoleSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddSection(Action<SectionBuilder> configure)
    {
        _payload.AddSection(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        _payload.AddSeparator(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        _payload.AddStringSelect(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        _payload.AddTextDisplay(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        _payload.AddTextInput(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        _payload.AddThumbnail(configure);
        return this;
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        _payload.AddUserSelect(configure);
        return this;
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithAttachments(List<PartialAttachment>? value)
    {
        _payload.WithAttachments(value);
        return this;
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitAttachments()
    {
        _payload.OmitAttachments();
        return this;
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddAttachment(PartialAttachment value)
    {
        _payload.AddAttachment(value);
        return this;
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithFlags(MessageFlags? value)
    {
        _payload.WithFlags(value);
        return this;
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitFlags()
    {
        _payload.OmitFlags();
        return this;
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithPoll(PollDefinition? value)
    {
        _payload.WithPoll(value);
        return this;
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder OmitPoll()
    {
        _payload.OmitPoll();
        return this;
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        _payload.WithPoll(configure);
        return this;
    }

    /// <summary>
    ///     Adds a replayable upload. Supported only by Discord's message and callback endpoints.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder AddFile(DiscordFile file)
    {
        _files.Add(file);
        return this;
    }

    /// <summary>
    ///     Sets the audit-log reason for endpoints that support it.
    /// </summary>
    public EditOriginalInteractionResponseRequestBuilder WithAuditLogReason(string? reason)
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