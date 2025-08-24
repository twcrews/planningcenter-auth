using Crews.PlanningCenter.Auth.Models;

namespace Crews.PlanningCenter.Auth.Configuration;

/// <summary>
/// Represents configuration options for the Planning Center OAuth <see cref="HttpClient"/> instance.
/// </summary>
public class PlanningCenterAuthClientOptions
{
    public PlanningCenterOAuthAuthorizationRequest AuthorizationRequest { get; set; }

    /// <summary>
    /// Gets or sets the Planning Center application's OAuth client secret.
    /// </summary>
    public required string ClientSecret { get; set; }
}
