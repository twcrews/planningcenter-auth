using Crews.PlanningCenter.Auth.Models;

namespace Crews.PlanningCenter.Auth;
public interface IOAuthClient
{
    /// <summary>
    /// Requests an access token from the OAuth server using the provided authorization code.
    /// </summary>
    /// <param name="authorizationCode">The authorization code received from the OAuth server.</param>
    /// <param name="redirectUri">The redirect URI used in the initial authorization request.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the access token response.</returns>
    Task<PlanningCenterOAuthTokenResponse> RequestAccessTokenAsync(string authorizationCode, Uri redirectUri);
    /// <summary>
    /// Refreshes an access token using the provided refresh token.
    /// </summary>
    /// <param name="refreshToken">The refresh token used to obtain a new access token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the new access token response.</returns>
    Task<PlanningCenterOAuthTokenResponse> RefreshAccessTokenAsync(string refreshToken);
}
