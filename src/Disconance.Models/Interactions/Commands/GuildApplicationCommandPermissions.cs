namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Guild Application Command Permissions data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
public class GuildApplicationCommandPermissions
{
    /// <summary>
    ///     ID of the command or the application ID.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     ID of the application the command belongs to.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     ID of the guild.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     Permissions for the command in the guild, max of 100.
    /// </summary>
    /// <remarks>Discord field: <c>permissions</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required List<ApplicationCommandPermission> Permissions { get; set; }
}