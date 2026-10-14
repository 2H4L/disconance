using Disconance.Models.Interactions;

namespace Disconance.Interactions.Modals;

/// <summary>
///     Handles modal submissions with application-defined custom ID matching.
/// </summary>
public interface IModalSubmitHandler
{
    /// <summary>
    ///     Matches the complete Discord custom ID. No delimiter or encoding is imposed by the library.
    /// </summary>
    bool CanHandle(string customId);

    /// <summary>
    ///     Executes the modal submission with its typed submitted values and returns the initial callback.
    /// </summary>
    Task<InteractionResponse> ExecuteAsync(Interaction interaction, ModalSubmitData data,
        CancellationToken cancellationToken = default);
}