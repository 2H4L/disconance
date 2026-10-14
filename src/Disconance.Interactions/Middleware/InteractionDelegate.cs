using Disconance.Models.Interactions;

namespace Disconance.Interactions.Middleware;

/// <summary>
///     Continues the interaction pipeline, returning null if no handler matches.
/// </summary>
public delegate Task<InteractionResponse?> InteractionDelegate();