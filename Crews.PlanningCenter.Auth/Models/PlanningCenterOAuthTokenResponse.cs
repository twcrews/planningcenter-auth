using Crews.PlanningCenter.Auth.Serialization;
using System.Text.Json.Serialization;

namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// OAuth token success response received from the Planning Center API.
/// </summary>
/// <param name="AccessToken">Access token issued by Planning Center.</param>
/// <param name="ExpiresIn">Validity lifetime of <paramref name="AccessToken"/>.</param>
/// <param name="RefreshToken">
/// A refresh token that applications can use to obtain another access token.
/// Planning Center's documented refresh token expiration policy is 90 days following its creation.
/// </param>
/// <param name="Scope">The scope of <paramref name="AccessToken"/>.</param>
/// <param name="CreatedAt">The time when the access token was created.</param>
/// <remarks>Per Planning Center documentation, the access token type will always be a Bearer token.</remarks>
public readonly record struct PlanningCenterOAuthTokenResponse(
    [property: JsonPropertyName("access_token")] string AccessToken,
    [property: JsonPropertyName("expires_in"), JsonConverter(typeof(SecondsToTimeSpanConverter))] TimeSpan? ExpiresIn,
    [property: JsonPropertyName("refresh_token")] string? RefreshToken,
    [property: JsonPropertyName("scope")] PlanningCenterOAuthScope? Scope,
    [property: JsonPropertyName("created_at"), JsonConverter(typeof(UnixTimestampToDateTimeOffsetConverter))] DateTimeOffset? CreatedAt);
