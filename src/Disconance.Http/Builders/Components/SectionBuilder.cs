using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Section values. Discord limits are documented on the model.
/// </summary>
public sealed class SectionBuilder : ModelBuilder<Section, SectionBuilder>
{
    /// <summary>
    ///     Composes Accessory as ActionRow.
    /// </summary>
    public SectionBuilder WithAccessoryActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Button.
    /// </summary>
    public SectionBuilder WithAccessoryButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as ChannelSelect.
    /// </summary>
    public SectionBuilder WithAccessoryChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Checkbox.
    /// </summary>
    public SectionBuilder WithAccessoryCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as CheckboxGroup.
    /// </summary>
    public SectionBuilder WithAccessoryCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Container.
    /// </summary>
    public SectionBuilder WithAccessoryContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as FileComponent.
    /// </summary>
    public SectionBuilder WithAccessoryFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as FileUpload.
    /// </summary>
    public SectionBuilder WithAccessoryFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as LabelComponent.
    /// </summary>
    public SectionBuilder WithAccessoryLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as MediaGallery.
    /// </summary>
    public SectionBuilder WithAccessoryMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as MentionableSelect.
    /// </summary>
    public SectionBuilder WithAccessoryMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as RadioGroup.
    /// </summary>
    public SectionBuilder WithAccessoryRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as RoleSelect.
    /// </summary>
    public SectionBuilder WithAccessoryRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Section.
    /// </summary>
    public SectionBuilder WithAccessorySection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Separator.
    /// </summary>
    public SectionBuilder WithAccessorySeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as StringSelect.
    /// </summary>
    public SectionBuilder WithAccessoryStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as TextDisplay.
    /// </summary>
    public SectionBuilder WithAccessoryTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as TextInput.
    /// </summary>
    public SectionBuilder WithAccessoryTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as Thumbnail.
    /// </summary>
    public SectionBuilder WithAccessoryThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Composes Accessory as UserSelect.
    /// </summary>
    public SectionBuilder WithAccessoryUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return WithAccessory(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit values, including defaults, remain present.
    /// </summary>
    public SectionBuilder WithComponents(List<Component> value)
    {
        return Set("Components", value);
    }

    /// <summary>
    ///     Appends one Component.
    /// </summary>
    public SectionBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public SectionBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public SectionBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public SectionBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public SectionBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public SectionBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public SectionBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public SectionBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public SectionBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public SectionBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public SectionBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public SectionBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public SectionBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public SectionBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public SectionBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public SectionBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public SectionBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public SectionBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public SectionBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public SectionBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public SectionBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Accessory; explicit values, including defaults, remain present.
    /// </summary>
    public SectionBuilder WithAccessory(Component value)
    {
        return Set("Accessory", value);
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public SectionBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public SectionBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}