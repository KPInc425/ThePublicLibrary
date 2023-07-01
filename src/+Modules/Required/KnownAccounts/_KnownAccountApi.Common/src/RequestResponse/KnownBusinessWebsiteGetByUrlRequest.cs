namespace KnownAccountsApi.Common.RequestResponse;
public class KnownBusinessWebsiteGetByUrlRequest
{
    public const string Route = "/api/KnownBusinessWebsite";
    public KnownBusinessWebsiteGetByUrlRequest(string url) {
        Url = Guard.Against.NullOrEmpty(url);
    }
    public string Url {get;set;}
    public static string BuildRoute() => Route;
}