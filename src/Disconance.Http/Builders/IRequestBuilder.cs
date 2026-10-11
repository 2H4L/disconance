namespace Disconance.Http.Builders;

/// <summary>
///     Produces a typed request without performing network operations.
/// </summary>
/// <typeparam name="TRequest">
///     The concrete request type.
/// </typeparam>
public interface IRequestBuilder<out TRequest>
{
    /// <summary>
    ///     Builds an independent request snapshot.
    /// </summary>
    TRequest Build();
}