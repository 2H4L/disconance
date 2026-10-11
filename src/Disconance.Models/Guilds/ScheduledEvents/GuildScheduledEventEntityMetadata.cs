namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Entity Metadata data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
public class GuildScheduledEventEntityMetadata
{
    /// <summary>
    ///     Location of the event (1-100 characters).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>location</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
    public Optional<string> Location { get; set; }
}