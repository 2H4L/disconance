namespace Disconance.Models.Users;

/// <summary>
///     Avatar Decoration Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#avatar-decoration-data-object" />
public class AvatarDecorationData
{
    /// <summary>
    ///     The avatar decoration hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>asset</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#avatar-decoration-data-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string Asset { get; set; }

    /// <summary>
    ///     Id of the avatar decoration's SKU.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>sku_id</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#avatar-decoration-data-object" />
    public required Snowflake SkuId { get; set; }
}