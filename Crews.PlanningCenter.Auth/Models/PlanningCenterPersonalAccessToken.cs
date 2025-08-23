using System.Net.Http.Headers;
using Crews.Extensions.Primitives;

namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// Represents a developer personal access token for the Planning Center API.
/// </summary>
public readonly record struct PlanningCenterPersonalAccessToken(string ApplicationID, string Secret)
{
    /// <summary>
    /// Implicitly converts the current <see cref="PlanningCenterPersonalAccessToken"/> instance to an
    /// <see cref="AuthenticationHeaderValue"/> instance.
    /// </summary>
    /// <param name="token">The current instance.</param>
    public static implicit operator AuthenticationHeaderValue(PlanningCenterPersonalAccessToken token)
        => new("Basic", $"{token.ApplicationID}:{token.Secret}".Base64Encode());
}
