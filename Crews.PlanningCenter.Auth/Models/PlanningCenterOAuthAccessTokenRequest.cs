namespace Crews.PlanningCenter.Auth.Models;

/// <summary>
/// Represets an access token request for the Planning Center API.
/// </summary>
/// <param name="AccessTokenUri">The URI for the access token request endpoint.</param>
/// <param name="ClientID">The requesting application's client ID.</param>
/// <param name="ClientSecret">The requesting application's client secret.</param>
/// <param name="AuthorizationCode">The authorization code issued by Planning Center.</param>
/// <param name="RedirectUri">The redirect URI registered by the requesting application.</param>
/// <param name="PkceCodeVerifier">The code verifier to send if using PKCE.</param>
public readonly record struct PlanningCenterOAuthAccessTokenRequest(
	Uri AccessTokenUri,
	string ClientID,
	string ClientSecret,
	string AuthorizationCode,
	Uri RedirectUri,
	string? PkceCodeVerifier)
{
	/// <summary>
	/// The constructed request message used to fetch the access token.
	/// </summary>
	public HttpRequestMessage RequestMessage
	{
		get
		{
			MultipartFormDataContent formData = new()
			{
				{ new StringContent("authorization_code"), "grant_type" },
				{ new StringContent(ClientID), "client_id" },
				{ new StringContent(ClientSecret), "client_secret" },
				{ new StringContent(RedirectUri.ToString()), "redirect_uri" },
				{ new StringContent(AuthorizationCode), "code" },
			};

			if (!string.IsNullOrWhiteSpace(PkceCodeVerifier))
				formData.Add(new StringContent(PkceCodeVerifier), "code_verifier");

			HttpRequestMessage requestMessage = new()
			{
				Method = HttpMethod.Post,
				Content = formData
			};

			return requestMessage;
		}
	}
}
