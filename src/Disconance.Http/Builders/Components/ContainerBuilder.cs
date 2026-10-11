using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Container values. Discord limits are documented on the model.
/// </summary>
public sealed class ContainerBuilder : ModelBuilder<Container, ContainerBuilder>
{
    /// <summary>
    ///     Sets Components; explicit values, including defaults, remain present.
    /// </summary>
    public ContainerBuilder WithComponents(List<Component> value)
    {
        return Set("Components", value);
    }

    /// <summary>
    ///     Appends one Component.
    /// </summary>
    public ContainerBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public ContainerBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public ContainerBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public ContainerBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public ContainerBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public ContainerBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public ContainerBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public ContainerBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public ContainerBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public ContainerBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public ContainerBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public ContainerBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public ContainerBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public ContainerBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public ContainerBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public ContainerBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public ContainerBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public ContainerBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public ContainerBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public ContainerBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public ContainerBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets AccentColor; explicit values, including defaults, remain present.
    /// </summary>
    public ContainerBuilder WithAccentColor(int? value)
    {
        return Set("AccentColor", new Optional<int?>(value));
    }

    /// <summary>
    ///     Omits AccentColor from the composition.
    /// </summary>
    public ContainerBuilder OmitAccentColor()
    {
        return Set("AccentColor", default(Optional<int?>));
    }

    /// <summary>
    ///     Sets Spoiler; explicit values, including defaults, remain present.
    /// </summary>
    public ContainerBuilder WithSpoiler(bool value)
    {
        return Set("Spoiler", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Spoiler from the composition.
    /// </summary>
    public ContainerBuilder OmitSpoiler()
    {
        return Set("Spoiler", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public ContainerBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public ContainerBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}