namespace Disconance.Models.Messages;

/// <summary>
///     Shared Client Theme data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#shared-client-theme-object" />
public class SharedClientTheme
{
    /// <summary>
    ///     The hexadecimal-encoded colors of the theme (max of 5).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>colors</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#shared-client-theme-object" />
    public required List<string> Colors { get; set; }

    /// <summary>
    ///     The direction of the theme's colors (max of 360).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>gradient_angle</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#shared-client-theme-object" />
    public required int GradientAngle { get; set; }

    /// <summary>
    ///     The intensity of the theme's colors (max of 100).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>base_mix</c>.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#shared-client-theme-object" />
    public required int BaseMix { get; set; }

    /// <summary>
    ///     The mode of the theme.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>base_theme</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#shared-client-theme-object" />
    public Optional<BaseThemeType?> BaseTheme { get; set; }
}