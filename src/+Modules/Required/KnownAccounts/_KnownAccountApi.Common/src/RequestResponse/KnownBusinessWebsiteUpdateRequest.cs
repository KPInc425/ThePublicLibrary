namespace KnownAccountsApi.Common.RequestResponse;
public class KnownBusinessWebsiteUpdateRequest
{
    public const string Route = "/api/KnownBusinessWebsite";
    private KnownBusinessWebsiteUpdateRequest() { }
    public KnownBusinessWebsiteUpdateRequest(KnownBusinessWebsiteViewModel website)
    {
        KnownBusinessWebsite = website;    
    }
    public KnownBusinessWebsiteViewModel KnownBusinessWebsite { get; set; }
    public static string BuildRoute() => Route;
}
