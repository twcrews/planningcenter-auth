namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// Represents the Proof of Key Code Exchange (PKCE) code challenge methods supported by the OAuth 2.0 protocol.
/// </summary>
public readonly record struct PkceCodeChallengeMethod
{
    private readonly string _value;

    /// <summary>
    /// The plain text method for the PKCE challenge. This method is less secure and generally not recommended.
    /// </summary>
    public static PkceCodeChallengeMethod Plain => new("plain");

    /// <summary>
    /// The SHA-256 hashing algorithm for the PKCE challenge method. This is the recommended method.
    /// </summary>
    public static PkceCodeChallengeMethod S256 => new("S256");

    /// <summary>
    /// Implicitly converts a <see cref="PkceCodeChallengeMethod"/> instance to its string representation.
    /// </summary>
    /// <param name="scope">The <see cref="PkceCodeChallengeMethod"/> instance to convert.</param>
    public static implicit operator string(PkceCodeChallengeMethod scope) => scope._value;

    /// <summary>
    /// Defines an implicit conversion from a <see cref="string"/> to a <see cref="PkceCodeChallengeMethod"/>.
    /// </summary>
    /// <param name="value">The string representation of the PKCE code challenge method.</param>
    public static implicit operator PkceCodeChallengeMethod(string value) => new(value);

    /// <summary>
    /// Returns a string equivalent to the serialized value of the PKCE code challenge method.
    /// </summary>
    /// <returns>The string representation of the PKCE code challenge method.</returns>
    public override string ToString() => _value;

    private PkceCodeChallengeMethod(string value) => _value = value;
}
