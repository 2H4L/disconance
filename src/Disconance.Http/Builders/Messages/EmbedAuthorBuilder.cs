using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes EmbedAuthor values. Discord limits are documented on the model.
/// </summary>
public sealed class EmbedAuthorBuilder : ModelBuilder<EmbedAuthor, EmbedAuthorBuilder>
{
    /// <summary>
    ///     Sets Name; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedAuthorBuilder WithName(string value)
    {
        return Set("Name", value);
    }

    /// <summary>
    ///     Sets Url; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedAuthorBuilder WithUrl(string value)
    {
        return Set("Url", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits Url from the composition.
    /// </summary>
    public EmbedAuthorBuilder OmitUrl()
    {
        return Set("Url", default(Optional<string>));
    }

    /// <summary>
    ///     Sets IconUrl; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedAuthorBuilder WithIconUrl(string value)
    {
        return Set("IconUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits IconUrl from the composition.
    /// </summary>
    public EmbedAuthorBuilder OmitIconUrl()
    {
        return Set("IconUrl", default(Optional<string>));
    }

    /// <summary>
    ///     Sets ProxyIconUrl; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedAuthorBuilder WithProxyIconUrl(string value)
    {
        return Set("ProxyIconUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ProxyIconUrl from the composition.
    /// </summary>
    public EmbedAuthorBuilder OmitProxyIconUrl()
    {
        return Set("ProxyIconUrl", default(Optional<string>));
    }
}