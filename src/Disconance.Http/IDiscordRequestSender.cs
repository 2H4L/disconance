using Disconance.Http.Requests;
using Disconance.Http.Responses;

namespace Disconance.Http;

/// <summary>
///     Sends typed requests; implement or decorate this interface to test or extend HTTP usage.
/// </summary>
public interface IDiscordRequestSender
{
    /// <summary>
    ///     Sends a request and returns its typed result; API failures throw DiscordHttpException.
    /// </summary>
    Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request, CancellationToken cancellationToken = default);
}