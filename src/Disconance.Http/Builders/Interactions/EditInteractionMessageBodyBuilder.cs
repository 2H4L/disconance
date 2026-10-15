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
///     Composes a EditInteractionMessageBody payload independently of transport.
/// </summary>
public sealed class
    EditInteractionMessageBodyBuilder : ModelBuilder<EditInteractionMessageBody, EditInteractionMessageBodyBuilder>
{
    /// <summary>
    ///     Sends explicit null for Embeds.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearEmbeds()
    {
        return WithEmbeds(null);
    }

    /// <summary>
    ///     Sends explicit null for Components.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearComponents()
    {
        return WithComponents(null);
    }

    /// <summary>
    ///     Sends explicit null for Attachments.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearAttachments()
    {
        return WithAttachments(null);
    }

    /// <summary>
    ///     Sends explicit null for Flags.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearFlags()
    {
        return WithFlags(null);
    }

    /// <summary>
    ///     Sends explicit null for Poll.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearPoll()
    {
        return WithPoll((PollDefinition?) null);
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithContent(string? value)
    {
        return Set("Content", new Optional<string?>(value));
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitContent()
    {
        return Set("Content", default(Optional<string?>));
    }

    /// <summary>
    ///     Sends an explicit null for Content.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearContent()
    {
        return WithContent(null);
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithEmbeds(List<Embed>? value)
    {
        return Set("Embeds", new Optional<List<Embed>?>(value));
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitEmbeds()
    {
        return Set("Embeds", default(Optional<List<Embed>?>));
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddEmbed(Embed value)
    {
        return Add("Embeds", value);
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedBuilder();
        configure(builder);
        return AddEmbed(builder.Build());
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithAllowedMentions(AllowedMentions? value)
    {
        return Set("AllowedMentions", new Optional<AllowedMentions?>(value));
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitAllowedMentions()
    {
        return Set("AllowedMentions", default(Optional<AllowedMentions?>));
    }

    /// <summary>
    ///     Sends an explicit null for AllowedMentions.
    /// </summary>
    public EditInteractionMessageBodyBuilder ClearAllowedMentions()
    {
        return WithAllowedMentions((AllowedMentions?) null);
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new AllowedMentionsBuilder();
        configure(builder);
        return WithAllowedMentions(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithComponents(List<Component>? value)
    {
        return Set("Components", new Optional<List<Component>?>(value));
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>?>));
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithAttachments(List<PartialAttachment>? value)
    {
        return Set("Attachments", new Optional<List<PartialAttachment>?>(value));
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitAttachments()
    {
        return Set("Attachments", default(Optional<List<PartialAttachment>?>));
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public EditInteractionMessageBodyBuilder AddAttachment(PartialAttachment value)
    {
        return Add("Attachments", value);
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithFlags(MessageFlags? value)
    {
        return Set("Flags", new Optional<MessageFlags?>(value));
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<MessageFlags?>));
    }

    /// <summary>
    ///     Sets Poll; explicit defaults remain present.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithPoll(PollDefinition? value)
    {
        return Set("Poll", new Optional<PollDefinition?>(value));
    }

    /// <summary>
    ///     Omits Poll.
    /// </summary>
    public EditInteractionMessageBodyBuilder OmitPoll()
    {
        return Set("Poll", default(Optional<PollDefinition?>));
    }

    /// <summary>
    ///     Composes Poll with a nested builder.
    /// </summary>
    public EditInteractionMessageBodyBuilder WithPoll(Action<PollDefinitionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new PollDefinitionBuilder();
        configure(builder);
        return WithPoll(builder.Build());
    }
}