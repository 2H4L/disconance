using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes LabelComponent values. Discord limits are documented on the model.
/// </summary>
public sealed class LabelComponentBuilder : ModelBuilder<LabelComponent, LabelComponentBuilder>
{
    /// <summary>
    ///     Composes Component as ActionRow.
    /// </summary>
    public LabelComponentBuilder WithComponentActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Button.
    /// </summary>
    public LabelComponentBuilder WithComponentButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as ChannelSelect.
    /// </summary>
    public LabelComponentBuilder WithComponentChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Checkbox.
    /// </summary>
    public LabelComponentBuilder WithComponentCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as CheckboxGroup.
    /// </summary>
    public LabelComponentBuilder WithComponentCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Container.
    /// </summary>
    public LabelComponentBuilder WithComponentContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as FileComponent.
    /// </summary>
    public LabelComponentBuilder WithComponentFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as FileUpload.
    /// </summary>
    public LabelComponentBuilder WithComponentFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as LabelComponent.
    /// </summary>
    public LabelComponentBuilder WithComponentLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as MediaGallery.
    /// </summary>
    public LabelComponentBuilder WithComponentMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as MentionableSelect.
    /// </summary>
    public LabelComponentBuilder WithComponentMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as RadioGroup.
    /// </summary>
    public LabelComponentBuilder WithComponentRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as RoleSelect.
    /// </summary>
    public LabelComponentBuilder WithComponentRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Section.
    /// </summary>
    public LabelComponentBuilder WithComponentSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Separator.
    /// </summary>
    public LabelComponentBuilder WithComponentSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as StringSelect.
    /// </summary>
    public LabelComponentBuilder WithComponentStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as TextDisplay.
    /// </summary>
    public LabelComponentBuilder WithComponentTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as TextInput.
    /// </summary>
    public LabelComponentBuilder WithComponentTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as Thumbnail.
    /// </summary>
    public LabelComponentBuilder WithComponentThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Composes Component as UserSelect.
    /// </summary>
    public LabelComponentBuilder WithComponentUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return WithComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Label; explicit values, including defaults, remain present.
    /// </summary>
    public LabelComponentBuilder WithLabel(string value)
    {
        return Set("Label", value);
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public LabelComponentBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public LabelComponentBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Component; explicit values, including defaults, remain present.
    /// </summary>
    public LabelComponentBuilder WithComponent(Component value)
    {
        return Set("Component", value);
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public LabelComponentBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public LabelComponentBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}