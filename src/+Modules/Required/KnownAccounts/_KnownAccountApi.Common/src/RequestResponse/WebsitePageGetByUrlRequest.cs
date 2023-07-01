namespace KnownAccountsApi.Common.RequestResponse;
public class WebsitePageGetByUrlRequest
{
    public const string Route = "/api/WebsitePage?Url={string:url}";

    [Required]
    public string Url { get; set; }

    private WebsitePageGetByUrlRequest() { }
    public WebsitePageGetByUrlRequest(string url)
    {
        Url = url;
    }

    public static string BuildRoute(string url) => Route.Replace("{string:url}", url);
}
