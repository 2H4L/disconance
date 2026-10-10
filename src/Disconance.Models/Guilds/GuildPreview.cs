using Disconance.Models.Emojis;
using Disconance.Models.Stickers;

namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Preview data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
public class GuildPreview
{
    /// <summary>
    ///     Guild id.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Guild name (2-100 characters).
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Icon hash.
    /// </summary>
    /// <remarks>Discord field: <c>icon</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Icon { get; set; }

    /// <summary>
    ///     Splash hash.
    /// </summary>
    /// <remarks>Discord field: <c>splash</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Splash { get; set; }

    /// <summary>
    ///     Discovery splash hash.
    /// </summary>
    /// <remarks>Discord field: <c>discovery_splash</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? DiscoverySplash { get; set; }

    /// <summary>
    ///     Custom guild emojis.
    /// </summary>
    /// <remarks>Discord field: <c>emojis</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required List<Emoji> Emojis { get; set; }

    /// <summary>
    ///     Enabled guild features.
    /// </summary>
    /// <remarks>Discord field: <c>features</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required List<string> Features { get; set; }

    /// <summary>
    ///     Approximate number of members in this guild.
    /// </summary>
    /// <remarks>Discord field: <c>approximate_member_count</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required int ApproximateMemberCount { get; set; }

    /// <summary>
    ///     Approximate number of online members in this guild.
    /// </summary>
    /// <remarks>Discord field: <c>approximate_presence_count</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required int ApproximatePresenceCount { get; set; }

    /// <summary>
    ///     The description for the guild.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be null.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required string? Description { get; set; }

    /// <summary>
    ///     Custom guild stickers.
    /// </summary>
    /// <remarks>Discord field: <c>stickers</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/resources/guild#guild-preview-object-guild-preview-structure" />
    public required List<Sticker> Stickers { get; set; }
}