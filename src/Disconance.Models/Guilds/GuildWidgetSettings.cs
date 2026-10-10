namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Widget Settings data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-widget-settings-object" />
public class GuildWidgetSettings
{
    /// <summary>
    ///     Whether the widget is enabled.
    /// </summary>
    /// <remarks>Discord field: <c>enabled</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-widget-settings-object" />
    public required bool Enabled { get; set; }

    /// <summary>
    ///     The widget channel id.
    /// </summary>
    /// <remarks>Discord field: <c>channel_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-widget-settings-object" />
    public required Snowflake? ChannelId { get; set; }
}