namespace Disconance.Models.Components;

/// <summary>
///     Select Default Value data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#user-select-select-default-value-structure" />
public class SelectDefaultValue
{
    /// <summary>
    ///     ID of a user, role, or channel.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     Type of value that <c>id</c> represents. Either <c>"user"</c> , <c>"role"</c> , or <c>"channel"</c> .
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public required string Type { get; set; }
}