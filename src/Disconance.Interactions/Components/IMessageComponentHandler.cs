using Disconance.Models.Interactions;

namespace Disconance.Interactions.Components;

/// <summary>
///     Handles message component interactions with application-defined custom ID matching.
/// </summary>
public interface IMessageComponentHandler
{
    /// <summary>
    ///     Matches the complete Discord custom ID. No delimiter or encoding is imposed by the library.
    /// </summary>
    bool CanHandle(string customId);

    /// <summary>
    ///     Executes the component interaction and returns its initial callback.
    /// </summary>
    Task<InteractionResponse> ExecuteAsync(Interaction interaction, MessageComponentData data,
        CancellationToken cancellationToken = default);
}