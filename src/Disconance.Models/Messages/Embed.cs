using Disconance.Models.Components;

namespace Disconance.Models.Messages;

/// <summary>
///     Embed data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
public class Embed
{
    /// <summary>
    ///     Title of embed.
    /// </summary>
    /// <remarks>Discord field: <c>title</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<string> Title { get; set; }

    /// <summary>
    ///     Type of embed (always "rich" for webhook embeds).
    /// </summary>
    /// <remarks>Discord field: <c>type</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<string> Type { get; set; }

    /// <summary>
    ///     Description of embed.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<string> Description { get; set; }

    /// <summary>
    ///     Url of embed.
    /// </summary>
    /// <remarks>Discord field: <c>url</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<string> Url { get; set; }

    /// <summary>
    ///     Timestamp of embed content.
    /// </summary>
    /// <remarks>Discord field: <c>timestamp</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<DateTimeOffset> Timestamp { get; set; }

    /// <summary>
    ///     Color code of the embed.
    /// </summary>
    /// <remarks>Discord field: <c>color</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<int> Color { get; set; }

    /// <summary>
    ///     Footer information.
    /// </summary>
    /// <remarks>Discord field: <c>footer</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedFooter> Footer { get; set; }

    /// <summary>
    ///     Image information.
    /// </summary>
    /// <remarks>Discord field: <c>image</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedImage> Image { get; set; }

    /// <summary>
    ///     Thumbnail information.
    /// </summary>
    /// <remarks>Discord field: <c>thumbnail</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedImage> Thumbnail { get; set; }

    /// <summary>
    ///     Video information.
    /// </summary>
    /// <remarks>Discord field: <c>video</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedVideo> Video { get; set; }

    /// <summary>
    ///     Provider information.
    /// </summary>
    /// <remarks>Discord field: <c>provider</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedProvider> Provider { get; set; }

    /// <summary>
    ///     Author information.
    /// </summary>
    /// <remarks>Discord field: <c>author</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<EmbedAuthor> Author { get; set; }

    /// <summary>
    ///     Fields information, max of 25.
    /// </summary>
    /// <remarks>Discord field: <c>fields</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    public Optional<List<EmbedField>> Fields { get; set; }

    /// <summary>
    ///     Components that make up the embed, only present on <c>components</c> type embeds. See Component Embeds.
    /// </summary>
    /// <remarks>Discord field: <c>components</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    /// <seealso href="https://docs.discord.com/developers/link-previews/component-embeds" />
    public Optional<List<Component>> Components { get; set; }

    /// <summary>
    ///     Embed flags combined as a bitfield.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<EmbedFlags> Flags { get; set; }
}