namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// Represents the initial request for the Planning Center OAuth flow.
/// </summary>
/// <param name="AuthorizationUri">The absolute URI of the authorization endpoint.</param>
/// <param name="ClientID">The requesting application's client ID.</param>
/// <param name="RedirectUri">The URI to which the client should be redirected following authorization.</param>
/// <param name="Scopes">The scopes for which to request authorization.</param>
/// <param name="CodeChallenge">The optional code challenge to send if using PKCE.</param>
/// <param name="CodeChallengeMethod">The code challenge method used for PKCE.</param>
public readonly record struct PlanningCenterOAuthAuthorizationRequest(
    Uri AuthorizationUri,
    string ClientID,
    Uri RedirectUri,
    PlanningCenterOAuthScope[] Scopes,
    string? CodeChallenge,
    PkceCodeChallengeMethod? CodeChallengeMethod)
{
    /// <summary>
    /// The constructed URI representation of the request.
    /// </summary>
    public Uri Uri => new UriBuilder(AuthorizationUri)
    {
        Query = $"client_id={ClientID}&redirect_uri={RedirectUri}&response_type=code&scope={Scopes}" +
                (CodeChallenge is not null
                    ? $"&code_challenge={CodeChallenge}&code_challenge_method={CodeChallengeMethod ?? PkceCodeChallengeMethod.S256}"
                    : string.Empty)
    }.Uri;
}
