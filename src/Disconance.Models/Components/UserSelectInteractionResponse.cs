using Disconance.Models.Interactions;

namespace Disconance.Models.Components;

/// <summary>
///     User Select Interaction Response data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
public class UserSelectInteractionResponse : ComponentInteractionResponse
{
    /// <summary>
    ///     <c>5</c> for a User Select.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public override ComponentType Type => Components.ComponentType.UserSelect;

    /// <summary>
    ///     <c>5</c> for a User Select.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>component_type</c> . Supplied in message component interactions; modal submissions use
    ///     type instead.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public Optional<ComponentType> ComponentType { get; set; }

    /// <summary>
    ///     Developer-defined identifier for the input; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     Resolved entities from selected options.
    /// </summary>
    /// <remarks>Discord field: <c>resolved</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public required ResolvedData Resolved { get; set; }

    /// <summary>
    ///     IDs of the selected users.
    /// </summary>
    /// <remarks>Discord field: <c>values</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/components/reference#user-select" />
    public required List<Snowflake> Values { get; set; }
}