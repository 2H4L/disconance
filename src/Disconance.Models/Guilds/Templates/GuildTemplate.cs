using Disconance.Models.Users;

namespace Disconance.Models.Guilds.Templates;

/// <summary>
///     Guild Template data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
public class GuildTemplate
{
    /// <summary>
    ///     The template code (unique ID).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>code</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required string Code { get; set; }

    /// <summary>
    ///     Template name.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     The description for the template.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required string? Description { get; set; }

    /// <summary>
    ///     Number of times this template has been used.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>usage_count</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required int UsageCount { get; set; }

    /// <summary>
    ///     The ID of the user who created the template.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>creator_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required Snowflake CreatorId { get; set; }

    /// <summary>
    ///     The user who created the template.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>creator</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required User Creator { get; set; }

    /// <summary>
    ///     When this template was created.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>created_at</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    ///     When this template was last synced to the source guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>updated_at</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    ///     The ID of the guild this template is based on.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>source_guild_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required Snowflake SourceGuildId { get; set; }

    /// <summary>
    ///     The guild snapshot this template contains; placeholder IDs are given as integers.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>serialized_source_guild</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required PartialGuild SerializedSourceGuild { get; set; }

    /// <summary>
    ///     Whether the template has unsynced changes.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>is_dirty</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild-template#guild-template-object" />
    public required bool? IsDirty { get; set; }
}