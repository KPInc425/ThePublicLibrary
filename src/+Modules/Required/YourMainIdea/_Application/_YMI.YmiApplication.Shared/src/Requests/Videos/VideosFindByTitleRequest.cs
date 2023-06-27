namespace YMI.YmiApplication.Shared.Requests;

public class VideosFindByTitleRequest : IYmiRoutable
{
    protected readonly static string Route = "/videos/findbytitle/?searchFor={searchFor}";

    [Required]
    public string SearchFor { get; set; }

    public VideosFindByTitleRequest(string searchFor)
    {
        SearchFor = searchFor;
    }

    public string BuildRouteFrom()
    {
        return VideosFindByTitleRequest.BuildRoute(SearchFor);
    }
    public static string BuildRoute(string searchFor) { return Route.Replace("{searchFor}", searchFor); }
}
