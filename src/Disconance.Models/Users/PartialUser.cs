namespace Disconance.Models.Users;

/// <summary>
///     A partial User resource. Each field may be absent; consult the source context for the supplied subset.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
public class PartialUser
{
    /// <summary>
    ///     The user's id.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>id</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<Snowflake> Id { get; set; }

    /// <summary>
    ///     The user's username, not unique across the platform.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>username</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<string> Username { get; set; }

    /// <summary>
    ///     The user's Discord-tag.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>discriminator</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<string> Discriminator { get; set; }

    /// <summary>
    ///     The user's display name, if it is set.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>global_name</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<string?> GlobalName { get; set; }

    /// <summary>
    ///     The user's avatar hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>avatar</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Avatar { get; set; }

    /// <summary>
    ///     Whether the user belongs to an OAuth2 application.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>bot</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<bool> Bot { get; set; }

    /// <summary>
    ///     Whether the user is an Official Discord System user (part of the urgent message system).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>system</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<bool> System { get; set; }

    /// <summary>
    ///     Whether the user has two factor enabled on their account.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>mfa_enabled</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<bool> MfaEnabled { get; set; }

    /// <summary>
    ///     The user's banner hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>banner</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public Optional<string?> Banner { get; set; }

    /// <summary>
    ///     The user's banner color encoded as an integer representation of hexadecimal color code.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>accent_color</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<int?> AccentColor { get; set; }

    /// <summary>
    ///     The user's chosen language option.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>locale</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#locales" />
    public Optional<string> Locale { get; set; }

    /// <summary>
    ///     Whether the email on this account has been verified.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>verified</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<bool> Verified { get; set; }

    /// <summary>
    ///     The user's email.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>email</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<string?> Email { get; set; }

    /// <summary>
    ///     The flags on a user's account.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<UserFlags> Flags { get; set; }

    /// <summary>
    ///     The type of Nitro subscription on a user's account.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>premium_type</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<PremiumType> PremiumType { get; set; }

    /// <summary>
    ///     The public flags on a user's account.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>public_flags</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<UserFlags> PublicFlags { get; set; }

    /// <summary>
    ///     Data for the user's avatar decoration.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>avatar_decoration_data</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<AvatarDecorationData?> AvatarDecorationData { get; set; }

    /// <summary>
    ///     Data for the user's collectibles.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>collectibles</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<Collectible?> Collectibles { get; set; }

    /// <summary>
    ///     The user's primary guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>primary_guild</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-structure" />
    public Optional<UserPrimaryGuild?> PrimaryGuild { get; set; }
}