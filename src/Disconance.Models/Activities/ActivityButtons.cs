namespace Disconance.Models.Activities;

/// <summary>
///     Activity buttons, whose received and supplied representations differ.
/// </summary>
/// <remarks>Received activities expose labels only. Supplied activities contain labels and URLs.</remarks>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-buttons" />
public abstract record ActivityButtons;

/// <summary>
///     Button labels received in an activity. Discord does not expose the URLs to bots.
/// </summary>
/// <param name="Labels">The received labels.</param>
public sealed record ActivityButtonLabels(List<string> Labels) : ActivityButtons;

/// <summary>
///     Buttons supplied when defining an activity.
/// </summary>
/// <param name="Buttons">Buttons containing labels and destination URLs.</param>
public sealed record ActivityButtonLinks(List<ActivityButton> Buttons) : ActivityButtons;