namespace Disconance.Models.Users;

/// <summary>
///     Collectible data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#collectibles-collectible-structure" />
public class Collectible
{
    /// <summary>
    ///     Object mapping of nameplate data.
    /// </summary>
    /// <remarks>Discord field: <c>nameplate</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#collectibles-collectible-structure" />
    public Optional<Nameplate> Nameplate { get; set; }
}