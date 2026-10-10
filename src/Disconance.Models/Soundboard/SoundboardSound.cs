using Disconance.Models.Users;

namespace Disconance.Models.Soundboard;

/// <summary>
///     Soundboard Sound data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
public class SoundboardSound
{
    /// <summary>
    ///     The name of this sound.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     The id of this sound.
    /// </summary>
    /// <remarks>Discord field: <c>sound_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required Snowflake SoundId { get; set; }

    /// <summary>
    ///     The volume of this sound, from 0 to 1.
    /// </summary>
    /// <remarks>Discord field: <c>volume</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required double Volume { get; set; }

    /// <summary>
    ///     The id of this sound's custom emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required Snowflake? EmojiId { get; set; }

    /// <summary>
    ///     The unicode character of this sound's standard emoji.
    /// </summary>
    /// <remarks>Discord field: <c>emoji_name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required string? EmojiName { get; set; }

    /// <summary>
    ///     The id of the guild this sound is in.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public Optional<Snowflake> GuildId { get; set; }

    /// <summary>
    ///     Whether this sound can be used, may be false due to loss of Server Boosts.
    /// </summary>
    /// <remarks>Discord field: <c>available</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public required bool Available { get; set; }

    /// <summary>
    ///     The user who created this sound.
    /// </summary>
    /// <remarks>Discord field: <c>user</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/soundboard#soundboard-sound-object" />
    public Optional<User> User { get; set; }
}