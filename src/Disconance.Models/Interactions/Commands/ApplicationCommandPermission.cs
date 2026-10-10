namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Permissions data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
public class ApplicationCommandPermission
{
    /// <summary>
    ///     ID of the role, user, or channel. It can also be a permission constant.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Role (<c>1</c>), user (<c>2</c>), or channel (<c>3</c>).
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required ApplicationCommandPermissionType Type { get; set; }

    /// <summary>
    ///     <c>true</c> to allow, <c>false</c> , to disallow.
    /// </summary>
    /// <remarks>Discord field: <c>permission</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/application-commands" />
    public required bool Permission { get; set; }
}