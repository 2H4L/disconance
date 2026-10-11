using Disconance.Http.Builders.Components;
using Disconance.Http.Builders.Messages;
using Disconance.Http.Builders.Polls;
using Disconance.Http.Requests.Interactions;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Composes a CreateFollowupMessageBody payload independently of transport.
/// </summary>
public sealed class
    CreateFollowupMessageBodyBuilder : ModelBuilder<CreateFollowupMessageBody, CreateFollowupMessageBodyBuilder>
{
    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithContent(string value)
    {
        return Set("Content", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitContent()
    {
        return Set("Content", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Tts; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithTts(bool value)
    {
        return Set("Tts", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Tts.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitTts()
    {
        return Set("Tts", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithEmbeds(List<Embed> value)
    {
        return Set("Embeds", new Optional<List<Embed>>(value));
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitEmbeds()
    {
        return Set("Embeds", default(Optional<List<Embed>>));
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddEmbed(Embed value)
    {
        return Add("Embeds", value);
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedBuilder();
        configure(builder);
        return AddEmbed(builder.Build());
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithAllowedMentions(AllowedMentions value)
    {
        return Set("AllowedMentions", new Optional<AllowedMentions>(value));
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitAllowedMentions()
    {
        return Set("AllowedMentions", default(Optional<AllowedMentions>));
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new AllowedMentionsBuilder();
        configure(builder);
        return WithAllowedMentions(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithComponents(List<Component> value)
    {
        return Set("Components", new Optional<List<Component>>(value));
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>>));
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithAttachments(List<PartialAttachment> value)
    {
        return Set("Attachments", new Optional<List<PartialAttachment>>(value));
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitAttachments()
    {
        return Set("Attachments", default(Optional<List<PartialAttachment>>));
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public CreateFollowupMessageBodyBuilder AddAttachment(PartialAttachment value)
    {
        return Add("Attachments", value);
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithFlags(MessageFlags value)
    {
        return Set("Flags", new Optional<MessageFlags>(value));
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<MessageFlags>));
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithPoll(PollDefinition value)
    {
        return Set("Poll", new Optional<PollDefinition>(value));
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public CreateFollowupMessageBodyBuilder OmitPoll()
    {
        return Set("Poll", default(Optional<PollDefinition>));
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public CreateFollowupMessageBodyBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollDefinitionBuilder();
        configure(builder);
        return WithPoll(builder.Build());
    }
}