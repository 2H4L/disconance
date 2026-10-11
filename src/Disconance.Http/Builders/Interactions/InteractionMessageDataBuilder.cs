using Disconance.Http.Builders.Components;
using Disconance.Http.Builders.Messages;
using Disconance.Http.Builders.Polls;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Messages;
using Disconance.Models.Polls;

namespace Disconance.Http.Builders.Interactions;

/// <summary>
///     Fluently composes InteractionMessageData values. Discord limits are documented on the model.
/// </summary>
public sealed class InteractionMessageDataBuilder : ModelBuilder<InteractionMessageData, InteractionMessageDataBuilder>
{
    /// <summary>
    ///     Sets Tts; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithTts(bool value)
    {
        return Set("Tts", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Tts from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitTts()
    {
        return Set("Tts", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Content; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithContent(string value)
    {
        return Set("Content", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Content from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitContent()
    {
        return Set("Content", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Embeds; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithEmbeds(List<Embed> value)
    {
        return Set("Embeds", new Optional<List<Embed>>(value));
    }

    /// <summary>
    ///     Omits Embeds from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitEmbeds()
    {
        return Set("Embeds", default(Optional<List<Embed>>));
    }

    /// <summary>
    ///     Appends one Embed.
    /// </summary>
    public InteractionMessageDataBuilder AddEmbed(Embed value)
    {
        return Add("Embeds", value);
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public InteractionMessageDataBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedBuilder();
        configure(builder);
        return AddEmbed(builder.Build());
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithAllowedMentions(AllowedMentions value)
    {
        return Set("AllowedMentions", new Optional<AllowedMentions>(value));
    }

    /// <summary>
    ///     Omits AllowedMentions from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitAllowedMentions()
    {
        return Set("AllowedMentions", default(Optional<AllowedMentions>));
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public InteractionMessageDataBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new AllowedMentionsBuilder();
        configure(builder);
        return WithAllowedMentions(builder.Build());
    }

    /// <summary>
    ///     Sets Flags; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithFlags(MessageFlags value)
    {
        return Set("Flags", new Optional<MessageFlags>(value));
    }

    /// <summary>
    ///     Omits Flags from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<MessageFlags>));
    }

    /// <summary>
    ///     Sets Components; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithComponents(List<Component> value)
    {
        return Set("Components", new Optional<List<Component>>(value));
    }

    /// <summary>
    ///     Omits Components from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>>));
    }

    /// <summary>
    ///     Appends one Component.
    /// </summary>
    public InteractionMessageDataBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public InteractionMessageDataBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public InteractionMessageDataBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public InteractionMessageDataBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public InteractionMessageDataBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public InteractionMessageDataBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public InteractionMessageDataBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public InteractionMessageDataBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public InteractionMessageDataBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public InteractionMessageDataBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public InteractionMessageDataBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public InteractionMessageDataBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public InteractionMessageDataBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public InteractionMessageDataBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public InteractionMessageDataBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public InteractionMessageDataBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public InteractionMessageDataBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public InteractionMessageDataBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public InteractionMessageDataBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public InteractionMessageDataBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public InteractionMessageDataBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Attachments; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithAttachments(List<PartialAttachment> value)
    {
        return Set("Attachments", new Optional<List<PartialAttachment>>(value));
    }

    /// <summary>
    ///     Omits Attachments from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitAttachments()
    {
        return Set("Attachments", default(Optional<List<PartialAttachment>>));
    }

    /// <summary>
    ///     Appends one Attachment.
    /// </summary>
    public InteractionMessageDataBuilder AddAttachment(PartialAttachment value)
    {
        return Add("Attachments", value);
    }

    /// <summary>
    ///     Sets Poll; explicit values, including defaults, remain present.
    /// </summary>
    public InteractionMessageDataBuilder WithPoll(PollDefinition value)
    {
        return Set("Poll", new Optional<PollDefinition>(value));
    }

    /// <summary>
    ///     Omits Poll from the composition.
    /// </summary>
    public InteractionMessageDataBuilder OmitPoll()
    {
        return Set("Poll", default(Optional<PollDefinition>));
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public InteractionMessageDataBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollDefinitionBuilder();
        configure(builder);
        return WithPoll(builder.Build());
    }
}