namespace Crews.PlanningCenter.Auth.Models;

public readonly record struct PlanningCenterOAuthAuthorizationRequest(
    Uri AuthorizationUri,
    string ClientID,
    Uri RedirectUri,
    PlanningCenterOAuthScope Scope,
    string? CodeChallenge,
    PkceCodeChallengeMethod? CodeChallengeMethod)
{
    public Uri Uri => new UriBuilder(AuthorizationUri)
    {
        Query = $"client_id={ClientID}&redirect_uri={RedirectUri}&response_type=code&scope={Scope}" +
                (CodeChallenge is not null
                    ? $"&code_challenge={CodeChallenge}&code_challenge_method={(CodeChallengeMethod ?? PkceCodeChallengeMethod.S256)}"
                    : string.Empty)
    }.Uri;
}
