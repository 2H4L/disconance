namespace Disconance.Models.Activities;

/// <summary>
///     Activity Secrets data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-secrets" />
public class ActivitySecrets
{
    /// <summary>
    ///     Secret for joining a party.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>join</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-secrets" />
    public Optional<string> Join { get; set; }

    /// <summary>
    ///     Secret for spectating a game.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>spectate</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-secrets" />
    public Optional<string> Spectate { get; set; }

    /// <summary>
    ///     Secret for a specific instanced match.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>match</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-secrets" />
    public Optional<string> Match { get; set; }
}