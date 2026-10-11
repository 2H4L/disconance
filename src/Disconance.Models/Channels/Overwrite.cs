using Disconance.Models.Permissions;

namespace Disconance.Models.Channels;

/// <summary>
///     Overwrite data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
public class Overwrite
{
    /// <summary>
    ///     Role or user id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Either 0 (role) or 1 (member).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
    public required OverwriteType Type { get; set; }

    /// <summary>
    ///     Permission bit set.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>allow</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
    public required PermissionFlags Allow { get; set; }

    /// <summary>
    ///     Permission bit set.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>deny</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
    public required PermissionFlags Deny { get; set; }
}