using System.Security.Cryptography;
using System.Text;

namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// Represents a PKCE (Proof Key for Code Exchange) code verifier used in OAuth 2.0 authorization flows.
/// </summary>
public readonly record struct PkceCodeVerifier
{
    /// <summary>
    /// The PKCE code verifier string. This string is URL-safe, making it ready for use with the "plain" code challenge
    /// method.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PkceCodeVerifier"/> struct with a securely generated, random
    /// code verifier string.
    /// </summary>
    public PkceCodeVerifier() => Value = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32))
        .TrimEnd('=')
        .Replace('+', '-')
        .Replace('/', '_');

    /// <summary>
    /// Generates a SHA-256-based code challenge from the current <see cref="PkceCodeVerifier"/> instance. The 
    /// resulting challenge string is URL-safe and Base64-encoded.
    /// </summary>
    /// <returns>A URL-safe, Base64-encoded SHA-256 code challenge string.</returns>
    public string GetSha256Challenge()
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(Value);
        byte[] hashBytes = SHA256.HashData(inputBytes);

        return Convert.ToBase64String(hashBytes)
            .Replace('+', '-')
            .Replace('/', '_')
            .Replace("=", "");
    }
}
