namespace KnownAccountsApi.Common.RequestResponse;
public class KnownBusinessWebsiteProfileUpdateRequest
{
    public const string Route = "/api/KnownBusinessWebsiteProfile";
    private KnownBusinessWebsiteProfileUpdateRequest() { }
    public KnownBusinessWebsiteProfileUpdateRequest(KnownBusinessWebsiteProfileViewModel knownBusinessWebsiteProfile)
    {
        KnownBusinessWebsiteProfile = knownBusinessWebsiteProfile;
    }
    public KnownBusinessWebsiteProfileViewModel KnownBusinessWebsiteProfile { get; set; }
    public static string BuildRoute() => Route;
}
