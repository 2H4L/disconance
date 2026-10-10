namespace Disconance.Models.Permissions;

/// <summary>
///     Role data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
public class Role
{
    /// <summary>
    ///     Role id.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Role name.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Deprecated integer representation of hexadecimal color code.
    /// </summary>
    /// <remarks>Discord field: <c>color</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required int Color { get; set; }

    /// <summary>
    ///     The role's colors.
    /// </summary>
    /// <remarks>Discord field: <c>colors</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required RoleColors Colors { get; set; }

    /// <summary>
    ///     If this role is pinned in the user listing.
    /// </summary>
    /// <remarks>Discord field: <c>hoist</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required bool Hoist { get; set; }

    /// <summary>
    ///     Role icon hash.
    /// </summary>
    /// <remarks>Discord field: <c>icon</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Icon { get; set; }

    /// <summary>
    ///     Role unicode emoji.
    /// </summary>
    /// <remarks>Discord field: <c>unicode_emoji</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<string?> UnicodeEmoji { get; set; }

    /// <summary>
    ///     Position of this role (roles with the same position are sorted by id).
    /// </summary>
    /// <remarks>Discord field: <c>position</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required int Position { get; set; }

    /// <summary>
    ///     Permission bit set.
    /// </summary>
    /// <remarks>Discord field: <c>permissions</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required PermissionFlags Permissions { get; set; }

    /// <summary>
    ///     Whether this role is managed by an integration.
    /// </summary>
    /// <remarks>Discord field: <c>managed</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required bool Managed { get; set; }

    /// <summary>
    ///     Whether this role is mentionable.
    /// </summary>
    /// <remarks>Discord field: <c>mentionable</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public required bool Mentionable { get; set; }

    /// <summary>
    ///     The tags this role has.
    /// </summary>
    /// <remarks>Discord field: <c>tags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<RoleTags> Tags { get; set; }

    /// <summary>
    ///     Role flags combined as a bitfield.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public required RoleFlags Flags { get; set; }
}