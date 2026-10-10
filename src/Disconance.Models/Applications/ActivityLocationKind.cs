namespace Disconance.Models.Applications;

/// <summary>
///     Known Discord activity location kind enum. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
public static class ActivityLocationKind
{
    /// <summary>
    ///     Location is a Guild Channel.
    /// </summary>
    public const string Gc = "gc";

    /// <summary>
    ///     Location is a Private Channel, such as a DM or GDM.
    /// </summary>
    public const string Pc = "pc";
}