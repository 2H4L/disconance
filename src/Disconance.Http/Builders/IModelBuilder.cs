namespace Disconance.Http.Builders;

/// <summary>
///     Builds an independent resource composition snapshot.
/// </summary>
/// <typeparam name="T">
///     The composed model.
/// </typeparam>
public interface IModelBuilder<out T>
{
    /// <summary>
    ///     Builds the model, rejecting missing required values.
    /// </summary>
    T Build();
}