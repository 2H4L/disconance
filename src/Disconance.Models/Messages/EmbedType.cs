namespace Disconance.Models.Messages;

/// <summary>
///     Known Discord embed types. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-types" />
public static class EmbedType
{
    /// <summary>
    ///     Generic embed rendered from embed attributes.
    /// </summary>
    public const string Rich = "rich";

    /// <summary>
    ///     Image embed
    /// </summary>
    public const string Image = "image";

    /// <summary>
    ///     Video embed
    /// </summary>
    public const string Video = "video";

    /// <summary>
    ///     Animated gif image embed rendered as a video embed.
    /// </summary>
    public const string Gifv = "gifv";

    /// <summary>
    ///     Article embed
    /// </summary>
    public const string Article = "article";

    /// <summary>
    ///     Link embed
    /// </summary>
    public const string Link = "link";

    /// <summary>
    ///     Poll result embed
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-fields-by-embed-type" />
    public const string PollResult = "poll_result";

    /// <summary>
    ///     Link preview built from Discord components, see Component Embeds.
    /// </summary>
    /// <seealso href="https://docs.discord.com/developers/link-previews/component-embeds" />
    public const string Components = "components";
}