using Crews.PlanningCenter.Auth.Configuration;
using Crews.PlanningCenter.Auth.Models;
using Microsoft.Extensions.Options;
using Crews.Extensions.Http;
using System.Security.Cryptography;

namespace Crews.PlanningCenter.Auth;
public class PlanningCenterAuthClient : IOAuthClient
{
    private readonly HttpClient _httpClient;

    public PlanningCenterAuthClient(HttpClient httpClient, IOptions<PlanningCenterAuthClientOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;

        _httpClient.SafelySetBaseAddress(_options.BaseAddress 
            ?? _httpClient.BaseAddress
            ?? new Uri("https://api.planningcenteronline.com/oauth"));
    }

    public Uri GetAuthorizationRequestUri() => new UriBuilder(_httpClient.BaseAddress!)
    {
        Query = $"client_id={_options.ClientID}&redirect_uri={_options.RedirectUri}&response_type=code&scope=people:read+people:write"
    }.Uri;

    public Task<PlanningCenterOAuthTokenResponse> RequestAccessTokenAsync(string authorizationCode)
    {
        using MultipartFormDataContent formData = [];
        formData.Add(new StringContent("authorization_code"), "grant_type");
        formData.Add(new StringContent(_options.ClientID), "client_id");
        formData.Add(new StringContent(_options.ClientSecret), "client_secret");
        formData.Add(new StringContent(_options.RedirectUri.ToString()), "redirect_uri");
        formData.Add(new StringContent(authorizationCode), "code");

        if (_options.UsePkce)
        {
            using RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[128];
            rng.GetBytes(bytes);

            if (_options.PkceCodeChallengeMethod == PkceCodeChallengeMethod.Plain)
            {

            }
        }
    }

    public Task<PlanningCenterOAuthTokenResponse> RefreshAccessTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }
}
