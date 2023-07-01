namespace KnownAccountsApi.Common.RequestResponse;
public class WebsitePageUpdateRequest
{
    public const string Route = "/api/WebsitePage";
    
    private WebsitePageUpdateRequest() { }
    public WebsitePageUpdateRequest(WebsitePageViewModel websitePage)
    {
        WebsitePage = websitePage;
    }
    public WebsitePageViewModel WebsitePage { get; set; }

    public static string BuildRoute() => Route;
}
