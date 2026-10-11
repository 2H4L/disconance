using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes EmbedFooter values. Discord limits are documented on the model.
/// </summary>
public sealed class EmbedFooterBuilder : ModelBuilder<EmbedFooter, EmbedFooterBuilder>
{
    /// <summary>
    ///     Sets Text; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFooterBuilder WithText(string value)
    {
        return Set("Text", value);
    }

    /// <summary>
    ///     Sets IconUrl; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFooterBuilder WithIconUrl(string value)
    {
        return Set("IconUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits IconUrl from the composition.
    /// </summary>
    public EmbedFooterBuilder OmitIconUrl()
    {
        return Set("IconUrl", default(Optional<string>));
    }

    /// <summary>
    ///     Sets ProxyIconUrl; explicit values, including defaults, remain present.
    /// </summary>
    public EmbedFooterBuilder WithProxyIconUrl(string value)
    {
        return Set("ProxyIconUrl", new Optional<string>(value));
    }

    /// <summary>
    ///     Omits ProxyIconUrl from the composition.
    /// </summary>
    public EmbedFooterBuilder OmitProxyIconUrl()
    {
        return Set("ProxyIconUrl", default(Optional<string>));
    }
}