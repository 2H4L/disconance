using Disconance.Http.Builders.Components;
using Disconance.Http.Builders.Polls;
using Disconance.Http.Requests.Messages;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Composes a CreateMessageBody payload independently of transport.
/// </summary>
public sealed class CreateMessageBodyBuilder : ModelBuilder<CreateMessageBody, CreateMessageBodyBuilder>
{
    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithContent(string value)
    {
        return Set("Content", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public CreateMessageBodyBuilder OmitContent()
    {
        return Set("Content", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Tts; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithTts(bool value)
    {
        return Set("Tts", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Tts.
    /// </summary>
    public CreateMessageBodyBuilder OmitTts()
    {
        return Set("Tts", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithEmbeds(List<Embed> value)
    {
        return Set("Embeds", new Optional<List<Embed>>(value));
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public CreateMessageBodyBuilder OmitEmbeds()
    {
        return Set("Embeds", default(Optional<List<Embed>>));
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public CreateMessageBodyBuilder AddEmbed(Embed value)
    {
        return Add("Embeds", value);
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public CreateMessageBodyBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedBuilder();
        configure(builder);
        return AddEmbed(builder.Build());
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithAllowedMentions(AllowedMentions value)
    {
        return Set("AllowedMentions", new Optional<AllowedMentions>(value));
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public CreateMessageBodyBuilder OmitAllowedMentions()
    {
        return Set("AllowedMentions", default(Optional<AllowedMentions>));
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public CreateMessageBodyBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new AllowedMentionsBuilder();
        configure(builder);
        return WithAllowedMentions(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithComponents(List<Component> value)
    {
        return Set("Components", new Optional<List<Component>>(value));
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public CreateMessageBodyBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>>));
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public CreateMessageBodyBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public CreateMessageBodyBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public CreateMessageBodyBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public CreateMessageBodyBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public CreateMessageBodyBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public CreateMessageBodyBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public CreateMessageBodyBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public CreateMessageBodyBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public CreateMessageBodyBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public CreateMessageBodyBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public CreateMessageBodyBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public CreateMessageBodyBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public CreateMessageBodyBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public CreateMessageBodyBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public CreateMessageBodyBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public CreateMessageBodyBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public CreateMessageBodyBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public CreateMessageBodyBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public CreateMessageBodyBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public CreateMessageBodyBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public CreateMessageBodyBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithAttachments(List<PartialAttachment> value)
    {
        return Set("Attachments", new Optional<List<PartialAttachment>>(value));
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public CreateMessageBodyBuilder OmitAttachments()
    {
        return Set("Attachments", default(Optional<List<PartialAttachment>>));
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public CreateMessageBodyBuilder AddAttachment(PartialAttachment value)
    {
        return Add("Attachments", value);
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithFlags(MessageFlags value)
    {
        return Set("Flags", new Optional<MessageFlags>(value));
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public CreateMessageBodyBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<MessageFlags>));
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithPoll(PollDefinition value)
    {
        return Set("Poll", new Optional<PollDefinition>(value));
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public CreateMessageBodyBuilder OmitPoll()
    {
        return Set("Poll", default(Optional<PollDefinition>));
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public CreateMessageBodyBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollDefinitionBuilder();
        configure(builder);
        return WithPoll(builder.Build());
    }

    /// <summary>
    ///     Sets Nonce; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithNonce(MessageNonce value)
    {
        return Set("Nonce", new Optional<MessageNonce>(value));
    }

    /// <summary>
    ///     Omits Nonce.
    /// </summary>
    public CreateMessageBodyBuilder OmitNonce()
    {
        return Set("Nonce", default(Optional<MessageNonce>));
    }

    /// <summary>
    ///     Sets EnforceNonce; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithEnforceNonce(bool value)
    {
        return Set("EnforceNonce", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits EnforceNonce.
    /// </summary>
    public CreateMessageBodyBuilder OmitEnforceNonce()
    {
        return Set("EnforceNonce", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets MessageReference; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithMessageReference(MessageReference value)
    {
        return Set("MessageReference", new Optional<MessageReference>(value));
    }

    /// <summary>
    ///     Omits MessageReference.
    /// </summary>
    public CreateMessageBodyBuilder OmitMessageReference()
    {
        return Set("MessageReference", default(Optional<MessageReference>));
    }

    /// <summary>
    ///     Sets StickerIds; explicit defaults remain present.
    /// </summary>
    public CreateMessageBodyBuilder WithStickerIds(List<Snowflake> value)
    {
        return Set("StickerIds", new Optional<List<Snowflake>>(value));
    }

    /// <summary>
    ///     Omits StickerIds.
    /// </summary>
    public CreateMessageBodyBuilder OmitStickerIds()
    {
        return Set("StickerIds", default(Optional<List<Snowflake>>));
    }

    /// <summary>
    ///     Appends StickerId.
    /// </summary>
    public CreateMessageBodyBuilder AddStickerId(Snowflake value)
    {
        return Add("StickerIds", value);
    }
}