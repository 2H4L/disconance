namespace Disconance.Models.Components;

/// <summary>
///     Known resource kinds for a select menu's default values.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/components/reference#user-select-select-default-value-structure" />
public static class SelectDefaultValueType
{
    /// <summary>
    ///     A user identifier.
    /// </summary>
    public const string User = "user";

    /// <summary>
    ///     A role identifier.
    /// </summary>
    public const string Role = "role";

    /// <summary>
    ///     A channel identifier.
    /// </summary>
    public const string Channel = "channel";
}