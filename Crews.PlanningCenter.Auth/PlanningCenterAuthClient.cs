using Crews.PlanningCenter.Auth.Configuration;
using Crews.PlanningCenter.Auth.Models;
using Microsoft.Extensions.Options;

namespace Crews.PlanningCenter.Auth;
public class PlanningCenterAuthClient : IOAuthClient
{
    private readonly HttpClient _httpClient;
    private readonly PlanningCenterAuthClientOptions _options;

    public PlanningCenterAuthClient(HttpClient httpClient, IOptions<PlanningCenterAuthClientOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;

        _httpClient.BaseAddress = _options.BaseAddress 
            ?? _httpClient.BaseAddress
            ?? new Uri("https://api.planningcenteronline.com/oauth");
    }

    public Task<PlanningCenterOAuthTokenResponse> RefreshAccessTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<PlanningCenterOAuthTokenResponse> RequestAccessTokenAsync(string authorizationCode, Uri redirectUri)
    {
        throw new NotImplementedException();
    }
}
