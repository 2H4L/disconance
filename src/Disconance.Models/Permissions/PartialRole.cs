namespace Disconance.Models.Permissions;

/// <summary>
///     A partial Role resource. Each field may be absent; consult the source context for the supplied subset.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
public class PartialRole
{
    /// <summary>
    ///     Role id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     Role name.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<string> Name { get; set; }

    /// <summary>
    ///     Deprecated integer representation of hexadecimal color code.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>color</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<int> Color { get; set; }

    /// <summary>
    ///     The role's colors.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>colors</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<RoleColors> Colors { get; set; }

    /// <summary>
    ///     If this role is pinned in the user listing.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>hoist</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<bool> Hoist { get; set; }

    /// <summary>
    ///     Role icon hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>icon</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Icon { get; set; }

    /// <summary>
    ///     Role unicode emoji.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>unicode_emoji</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<string?> UnicodeEmoji { get; set; }

    /// <summary>
    ///     Position of this role (roles with the same position are sorted by id).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>position</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<int> Position { get; set; }

    /// <summary>
    ///     Permission bit set.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>permissions</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<PermissionFlags> Permissions { get; set; }

    /// <summary>
    ///     Whether this role is managed by an integration.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>managed</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<bool> Managed { get; set; }

    /// <summary>
    ///     Whether this role is mentionable.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>mentionable</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<bool> Mentionable { get; set; }

    /// <summary>
    ///     The tags this role has.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>tags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    public Optional<RoleTags> Tags { get; set; }

    /// <summary>
    ///     Role flags combined as a bitfield.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-structure" />
    /// <seealso href="https://en.wikipedia.org/wiki/Bit_field" />
    public Optional<RoleFlags> Flags { get; set; }
}