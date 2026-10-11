namespace Disconance.Models.Messages;

/// <summary>
///     Embed Provider data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-provider-structure" />
public class EmbedProvider
{
    /// <summary>
    ///     Name of provider.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-provider-structure" />
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     Url of provider.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>url</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#embed-object-embed-provider-structure" />
    public Optional<string> Url { get; set; }
}