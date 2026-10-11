namespace Disconance.Models.Applications.IdentityProfiles;

/// <summary>
///     Primary Profile Data data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/application-identity-profile#primary-profile-data-object" />
public class PrimaryProfileData
{
    /// <summary>
    ///     Current season name (e.g. "Season 3").
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>season</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<string> Season { get; set; }

    /// <summary>
    ///     Current rank name (e.g. "Silver").
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>rank_name</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<string> RankName { get; set; }

    /// <summary>
    ///     Image representing the current rank.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>rank_image</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<Media> RankImage { get; set; }

    /// <summary>
    ///     Highest rank achieved.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>highest_rank</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<string> HighestRank { get; set; }

    /// <summary>
    ///     Image representing the highest rank achieved.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>highest_rank_image</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<Media> HighestRankImage { get; set; }

    /// <summary>
    ///     Name of the featured played character.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>featured_played_character</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<string> FeaturedPlayedCharacter { get; set; }

    /// <summary>
    ///     Image of the featured played character.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>featured_played_character_image</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<Media> FeaturedPlayedCharacterImage { get; set; }

    /// <summary>
    ///     Total playtime in hours; accepts decimal values (e.g. <c>69.41</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>playtime_hours</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<double> PlaytimeHours { get; set; }

    /// <summary>
    ///     Total number of wins.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_wins</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> TotalWins { get; set; }

    /// <summary>
    ///     Wins in the current period (e.g. season).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_wins</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> CurrentPeriodWins { get; set; }

    /// <summary>
    ///     Total number of games played.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_games</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> TotalGames { get; set; }

    /// <summary>
    ///     Games played in the current period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_games</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> CurrentPeriodGames { get; set; }

    /// <summary>
    ///     Total number of kills.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_kills</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> TotalKills { get; set; }

    /// <summary>
    ///     Kills in the current period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_kills</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> CurrentPeriodKills { get; set; }

    /// <summary>
    ///     Total number of assists.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_assists</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> TotalAssists { get; set; }

    /// <summary>
    ///     Assists in the current period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_assists</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> CurrentPeriodAssists { get; set; }

    /// <summary>
    ///     Total number of deaths.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>total_deaths</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> TotalDeaths { get; set; }

    /// <summary>
    ///     Deaths in the current period.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>current_period_deaths</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application-identity-profile" />
    public Optional<int> CurrentPeriodDeaths { get; set; }
}