using Disconance.Http.Builders.Components;
using Disconance.Models;
using Disconance.Models.Components;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes Embed values. Discord limits are documented on the model.
/// </summary>
public sealed class EmbedBuilder : ModelBuilder<Embed, EmbedBuilder>
{
    /// <summary>
    ///     Sets Title; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithTitle(string value)
    {
        return Set("Title", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Title from the composition.
    /// </summary>
    public EmbedBuilder OmitTitle()
    {
        return Set("Title", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Type; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithType(string value)
    {
        return Set("Type", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Type from the composition.
    /// </summary>
    public EmbedBuilder OmitType()
    {
        return Set("Type", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Description; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithDescription(string value)
    {
        return Set("Description", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Description from the composition.
    /// </summary>
    public EmbedBuilder OmitDescription()
    {
        return Set("Description", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Url; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithUrl(string value)
    {
        return Set("Url", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Url from the composition.
    /// </summary>
    public EmbedBuilder OmitUrl()
    {
        return Set("Url", default(Optional<string>));
    }

    /// <summary>
    ///     Sets Timestamp; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithTimestamp(DateTimeOffset value)
    {
        return Set("Timestamp", new Optional<DateTimeOffset>(value));
    }

    /// <summary>
    ///     Omits Timestamp from the composition.
    /// </summary>
    public EmbedBuilder OmitTimestamp()
    {
        return Set("Timestamp", default(Optional<DateTimeOffset>));
    }

    /// <summary>
    ///     Sets Color; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithColor(int value)
    {
        return Set("Color", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Color from the composition.
    /// </summary>
    public EmbedBuilder OmitColor()
    {
        return Set("Color", default(Optional<int>));
    }

    /// <summary>
    ///     Sets Footer; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithFooter(EmbedFooter value)
    {
        return Set("Footer", new Optional<EmbedFooter>(value));
    }

    /// <summary>
    ///     Omits Footer from the composition.
    /// </summary>
    public EmbedBuilder OmitFooter()
    {
        return Set("Footer", default(Optional<EmbedFooter>));
    }

    /// <summary>
    ///     Composes Footer with a nested builder.
    /// </summary>
    public EmbedBuilder WithFooter(Action<EmbedFooterBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedFooterBuilder();
        configure(builder);
        return WithFooter(builder.Build());
    }

    /// <summary>
    ///     Sets Image; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithImage(EmbedImage value)
    {
        return Set("Image", new Optional<EmbedImage>(value));
    }

    /// <summary>
    ///     Omits Image from the composition.
    /// </summary>
    public EmbedBuilder OmitImage()
    {
        return Set("Image", default(Optional<EmbedImage>));
    }

    /// <summary>
    ///     Composes Image with a nested builder.
    /// </summary>
    public EmbedBuilder WithImage(Action<EmbedImageBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedImageBuilder();
        configure(builder);
        return WithImage(builder.Build());
    }

    /// <summary>
    ///     Sets Thumbnail; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithThumbnail(EmbedImage value)
    {
        return Set("Thumbnail", new Optional<EmbedImage>(value));
    }

    /// <summary>
    ///     Omits Thumbnail from the composition.
    /// </summary>
    public EmbedBuilder OmitThumbnail()
    {
        return Set("Thumbnail", default(Optional<EmbedImage>));
    }

    /// <summary>
    ///     Composes Thumbnail with a nested builder.
    /// </summary>
    public EmbedBuilder WithThumbnail(Action<EmbedImageBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedImageBuilder();
        configure(builder);
        return WithThumbnail(builder.Build());
    }

    /// <summary>
    ///     Sets Video; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithVideo(EmbedVideo value)
    {
        return Set("Video", new Optional<EmbedVideo>(value));
    }

    /// <summary>
    ///     Omits Video from the composition.
    /// </summary>
    public EmbedBuilder OmitVideo()
    {
        return Set("Video", default(Optional<EmbedVideo>));
    }

    /// <summary>
    ///     Sets Provider; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithProvider(EmbedProvider value)
    {
        return Set("Provider", new Optional<EmbedProvider>(value));
    }

    /// <summary>
    ///     Omits Provider from the composition.
    /// </summary>
    public EmbedBuilder OmitProvider()
    {
        return Set("Provider", default(Optional<EmbedProvider>));
    }

    /// <summary>
    ///     Sets Author; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithAuthor(EmbedAuthor value)
    {
        return Set("Author", new Optional<EmbedAuthor>(value));
    }

    /// <summary>
    ///     Omits Author from the composition.
    /// </summary>
    public EmbedBuilder OmitAuthor()
    {
        return Set("Author", default(Optional<EmbedAuthor>));
    }

    /// <summary>
    ///     Composes Author with a nested builder.
    /// </summary>
    public EmbedBuilder WithAuthor(Action<EmbedAuthorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedAuthorBuilder();
        configure(builder);
        return WithAuthor(builder.Build());
    }

    /// <summary>
    ///     Sets Fields; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithFields(List<EmbedField> value)
    {
        return Set("Fields", new Optional<List<EmbedField>>(value));
    }

    /// <summary>
    ///     Omits Fields from the composition.
    /// </summary>
    public EmbedBuilder OmitFields()
    {
        return Set("Fields", default(Optional<List<EmbedField>>));
    }

    /// <summary>
    ///     Appends one Field.
    /// </summary>
    public EmbedBuilder AddField(EmbedField value)
    {
        return Add("Fields", value);
    }

    /// <summary>
    ///     Composes and appends EmbedField.
    /// </summary>
    public EmbedBuilder AddField(Action<EmbedFieldBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new EmbedFieldBuilder();
        configure(builder);
        return AddField(builder.Build());
    }

    /// <summary>
    ///     Sets Components; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithComponents(List<Component> value)
    {
        return Set("Components", new Optional<List<Component>>(value));
    }

    /// <summary>
    ///     Omits Components from the composition.
    /// </summary>
    public EmbedBuilder OmitComponents()
    {
        return Set("Components", default(Optional<List<Component>>));
    }

    /// <summary>
    ///     Appends one Component.
    /// </summary>
    public EmbedBuilder AddComponent(Component value)
    {
        return Add("Components", value);
    }

    /// <summary>
    ///     Composes and appends ActionRow.
    /// </summary>
    public EmbedBuilder AddActionRow(Action<ActionRowBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ActionRowBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Button.
    /// </summary>
    public EmbedBuilder AddButton(Action<ButtonBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ButtonBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends ChannelSelect.
    /// </summary>
    public EmbedBuilder AddChannelSelect(Action<ChannelSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ChannelSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Checkbox.
    /// </summary>
    public EmbedBuilder AddCheckbox(Action<CheckboxBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends CheckboxGroup.
    /// </summary>
    public EmbedBuilder AddCheckboxGroup(Action<CheckboxGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new CheckboxGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Container.
    /// </summary>
    public EmbedBuilder AddContainer(Action<ContainerBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ContainerBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileComponent.
    /// </summary>
    public EmbedBuilder AddFile(Action<FileComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends FileUpload.
    /// </summary>
    public EmbedBuilder AddFileUpload(Action<FileUploadBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new FileUploadBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends LabelComponent.
    /// </summary>
    public EmbedBuilder AddLabel(Action<LabelComponentBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new LabelComponentBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MediaGallery.
    /// </summary>
    public EmbedBuilder AddMediaGallery(Action<MediaGalleryBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MediaGalleryBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends MentionableSelect.
    /// </summary>
    public EmbedBuilder AddMentionableSelect(Action<MentionableSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new MentionableSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RadioGroup.
    /// </summary>
    public EmbedBuilder AddRadioGroup(Action<RadioGroupBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RadioGroupBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends RoleSelect.
    /// </summary>
    public EmbedBuilder AddRoleSelect(Action<RoleSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new RoleSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Section.
    /// </summary>
    public EmbedBuilder AddSection(Action<SectionBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SectionBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Separator.
    /// </summary>
    public EmbedBuilder AddSeparator(Action<SeparatorBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new SeparatorBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends StringSelect.
    /// </summary>
    public EmbedBuilder AddStringSelect(Action<StringSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new StringSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextDisplay.
    /// </summary>
    public EmbedBuilder AddTextDisplay(Action<TextDisplayBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextDisplayBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends TextInput.
    /// </summary>
    public EmbedBuilder AddTextInput(Action<TextInputBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new TextInputBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends Thumbnail.
    /// </summary>
    public EmbedBuilder AddThumbnail(Action<ThumbnailBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new ThumbnailBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Composes and appends UserSelect.
    /// </summary>
    public EmbedBuilder AddUserSelect(Action<UserSelectBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);
        var builder = new UserSelectBuilder();
        configure(builder);
        return AddComponent(builder.Build());
    }

    /// <summary>
    ///     Sets Flags; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedBuilder WithFlags(EmbedFlags value)
    {
        return Set("Flags", new Optional<EmbedFlags>(value));
    }

    /// <summary>
    ///     Omits Flags from the composition.
    /// </summary>
    public EmbedBuilder OmitFlags()
    {
        return Set("Flags", default(Optional<EmbedFlags>));
    }
}