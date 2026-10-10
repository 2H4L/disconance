namespace Disconance.Models.Interactions;

/// <summary>
///     Interaction Callback Activity Instance Resource data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
public class InteractionCallbackActivityInstance
{
    /// <summary>
    ///     Instance ID of the Activity if one was launched or joined.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-callback" />
    public required string Id { get; set; }
}