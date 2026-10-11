namespace Disconance.Models.Activities;

/// <summary>
///     Activity Party data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-party" />
public class ActivityParty
{
    /// <summary>
    ///     ID of the party.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-party" />
    public Optional<string> Id { get; set; }

    /// <summary>
    ///     Used to show the party's current and maximum size.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>size</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-party" />
    public Optional<List<int>> Size { get; set; }
}