namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownBusinessWebsiteGetRequest
{
    public const string Route = "/api/KnownBusinessWebsite";
    public KnownBusinessWebsiteGetRequest()
    { }
    public static string BuildRoute() => Route;
}