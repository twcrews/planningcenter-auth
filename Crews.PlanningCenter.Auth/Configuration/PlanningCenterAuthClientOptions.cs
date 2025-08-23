namespace Crews.PlanningCenter.Auth.Configuration;

/// <summary>
/// Represents configuration options for the Planning Center OAuth <see cref="HttpClient"/> instance.
/// </summary>
public class PlanningCenterAuthClientOptions
{
    /// <summary>
    /// Gets or sets the base address of the client. This should be the Planning Center API OAuth address.
    /// </summary>
    /// <remarks>
    /// This property will override the <see cref="HttpClient.BaseAddress"/> property of the <see cref="HttpClient"/> instance.
    /// If neither is set, the default value will be <c>https://api.planningcenteronline.com/oauth</c>.
    /// </remarks>
    public Uri? BaseAddress { get; set; }

    /// <summary>
    /// Gets or sets the Planning Center application's OAuth client ID.
    /// </summary>
    public required string ClientID { get; set; }

    /// <summary>
    /// Gets or sets the Planning Center application's OAuth client secret.
    /// </summary>
    public required string ClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the URI to which the user will be redirected after authentication.
    /// </summary>
    /// <remarks>Ensure that the URI is properly configured to handle the authentication response.  Relative
    /// URIs are not supported.</remarks>
    public required Uri RedirectUri { get; set; }
}
