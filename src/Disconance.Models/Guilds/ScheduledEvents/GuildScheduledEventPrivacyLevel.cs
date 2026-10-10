namespace Disconance.Models.Guilds.ScheduledEvents;

/// <summary>
///     Guild Scheduled Event Privacy Level defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-scheduled-event#guild-scheduled-event-object" />
public enum GuildScheduledEventPrivacyLevel
{
    /// <summary>
    ///     The scheduled event is only accessible to guild members.
    /// </summary>
    GuildOnly = 2
}