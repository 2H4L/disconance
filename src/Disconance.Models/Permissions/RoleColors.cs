namespace Disconance.Models.Permissions;

/// <summary>
///     Role Colors data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-colors-object" />
public class RoleColors
{
    /// <summary>
    ///     The primary color for the role.
    /// </summary>
    /// <remarks>Discord field: <c>primary_color</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-colors-object" />
    public required int PrimaryColor { get; set; }

    /// <summary>
    ///     The secondary color for the role, this will make the role a gradient between the other provided colors.
    /// </summary>
    /// <remarks>Discord field: <c>secondary_color</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-colors-object" />
    public required int? SecondaryColor { get; set; }

    /// <summary>
    ///     The tertiary color for the role, this will turn the gradient into a holographic style.
    /// </summary>
    /// <remarks>Discord field: <c>tertiary_color</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-colors-object" />
    public required int? TertiaryColor { get; set; }
}