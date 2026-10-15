using Disconance.Http.Builders.Components;
using Disconance.Http.Requests.Messages;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Composes a EditMessageBody payload independently of transport.
/// </summary>
public sealed class EditMessageBodyBuilder : ModelBuilder<EditMessageBody, EditMessageBodyBuilder>
{
    /// <summary>
    ///     Sends explicit null for Embeds.
    /// </summary>
    public EditMessageBodyBuilder ClearEmbeds()
    {
        return WithEmbeds(null);
    }

    /// <summary>
    ///     Sends explicit null for Components.
    /// </summary>
    public EditMessageBodyBuilder ClearComponents()
    {
        return WithComponents(null);
    }

    /// <summary>
    ///     Sends explicit null for Attachments.
    /// </summary>
    public EditMessageBodyBuilder ClearAttachments()
    {
        return WithAttachments(null);
    }

    /// <summary>
    ///     Sends explicit null for Flags.
    /// </summary>
    public EditMessageBodyBuilder ClearFlags()
    {
        return WithFlags(null);
    }

    /// <summary>
    ///     Sets Content; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithContent(string? value)
    {
        return Set("Content", new Optional<string?>(value));
    }

    /// <summary>
    ///     Omits Content.
    /// </summary>
    public EditMessageBodyBuilder OmitContent()
    {
        return Set("Content", default(Optional<string?>));
    }

    /// <summary>
    ///     Sends an explicit null for Content.
    /// </summary>
    public EditMessageBodyBuilder ClearContent()
    {
        return WithContent(null);
    }

    /// <summary>
    ///     Sets Embeds; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithEmbeds(List<Embed>? value)
    {
        return Set("Embeds", new Optional<List<Embed>?>(value));
    }

    /// <summary>
    ///     Omits Embeds.
    /// </summary>
    public EditMessageBodyBuilder OmitEmbeds()
    {
        return Set("Embeds", default(Optional<List<Embed>?>));
    }

    /// <summary>
    ///     Appends Embed.
    /// </summary>
    public EditMessageBodyBuilder AddEmbed(Embed value)
    {
        return Add("Embeds", value);
    }

    /// <summary>
    ///     Composes and appends Embed.
    /// </summary>
    public EditMessageBodyBuilder AddEmbed(Action<EmbedBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedBuilder();
        configure(builder);
        return AddEmbed(builder.Build());
    }

    /// <summary>
    ///     Sets AllowedMentions; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithAllowedMentions(AllowedMentions? value)
    {
        return Set("AllowedMentions", new Optional<AllowedMentions?>(value));
    }

    /// <summary>
    ///     Omits AllowedMentions.
    /// </summary>
    public EditMessageBodyBuilder OmitAllowedMentions()
    {
        return Set("AllowedMentions", default(Optional<AllowedMentions?>));
    }

    /// <summary>
    ///     Sends an explicit null for AllowedMentions.
    /// </summary>
    public EditMessageBodyBuilder ClearAllowedMentions()
    {
        return WithAllowedMentions((AllowedMentions?) null);
    }

    /// <summary>
    ///     Composes AllowedMentions with a nested builder.
    /// </summary>
    public EditMessageBodyBuilder WithAllowedMentions(Action<AllowedMentionsBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new AllowedMentionsBuilder();
        configure(builder);
        return WithAllowedMentions(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithComponents(List<Component>? value)
    {
        return Set("Components", new Optional<List<Component>?>(value));
    }

    /// <summary>
    ///     Omits Components.
    /// </summary>
    public EditMessageBodyBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>?>));
    }

    /// <summary>
    ///     Appends Component.
    /// </summary>
    public EditMessageBodyBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EditMessageBodyBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EditMessageBodyBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EditMessageBodyBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EditMessageBodyBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EditMessageBodyBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EditMessageBodyBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EditMessageBodyBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EditMessageBodyBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EditMessageBodyBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EditMessageBodyBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EditMessageBodyBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EditMessageBodyBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EditMessageBodyBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EditMessageBodyBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EditMessageBodyBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EditMessageBodyBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EditMessageBodyBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EditMessageBodyBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EditMessageBodyBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EditMessageBodyBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Attachments; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithAttachments(List<PartialAttachment>? value)
    {
        return Set("Attachments", new Optional<List<PartialAttachment>?>(value));
    }

    /// <summary>
    ///     Omits Attachments.
    /// </summary>
    public EditMessageBodyBuilder OmitAttachments()
    {
        return Set("Attachments", default(Optional<List<PartialAttachment>?>));
    }

    /// <summary>
    ///     Appends Attachment.
    /// </summary>
    public EditMessageBodyBuilder AddAttachment(PartialAttachment value)
    {
        return Add("Attachments", value);
    }

    /// <summary>
    ///     Sets Flags; explicit defaults remain present.
    /// </summary>
    public EditMessageBodyBuilder WithFlags(MessageFlags? value)
    {
        return Set("Flags", new Optional<MessageFlags?>(value));
    }

    /// <summary>
    ///     Omits Flags.
    /// </summary>
    public EditMessageBodyBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<MessageFlags?>));
    }
}