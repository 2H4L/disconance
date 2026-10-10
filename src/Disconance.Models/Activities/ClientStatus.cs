namespace Disconance.Models.Activities;

/// <summary>
///     Client Status data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#client-status-object" />
public class ClientStatus
{
    /// <summary>
    ///     User's status set for an active desktop (Windows, Linux, Mac) application session.
    /// </summary>
    /// <remarks>Discord field: <c>desktop</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#client-status-object" />
    public Optional<string> Desktop { get; set; }

    /// <summary>
    ///     User's status set for an active mobile (iOS, Android) application session.
    /// </summary>
    /// <remarks>Discord field: <c>mobile</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#client-status-object" />
    public Optional<string> Mobile { get; set; }

    /// <summary>
    ///     User's status set for an active web (browser, bot user) application session.
    /// </summary>
    /// <remarks>Discord field: <c>web</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#client-status-object" />
    public Optional<string> Web { get; set; }

    /// <summary>
    ///     User's status set for an active virtual reality application session.
    /// </summary>
    /// <remarks>Discord field: <c>vr</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#client-status-object" />
    public Optional<string> Vr { get; set; }
}