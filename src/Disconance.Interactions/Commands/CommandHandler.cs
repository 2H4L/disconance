using Disconance.Models.Interactions;

namespace Disconance.Interactions.Commands;

/// <summary>
///     Execution and autocomplete behavior shared by top-level commands and subcommands.
/// </summary>
public abstract class CommandHandler
{
    /// <summary>
    ///     Executes the selected command and returns its initial callback.
    /// </summary>
    public abstract Task<InteractionResponse> ExecuteAsync(CommandContext context,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Returns choices for the focused option. The default returns an empty choice list.
    /// </summary>
    public virtual Task<InteractionResponse> AutocompleteAsync(CommandContext context,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return Task.FromResult(new InteractionResponse
        {
            Type = InteractionCallbackType.ApplicationCommandAutocompleteResult,
            Data = new InteractionAutocompleteData { Choices = [] }
        });
    }
}