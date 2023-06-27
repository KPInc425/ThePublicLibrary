namespace YMI.YmiApplication.Shared.Requests;

public class VideosGetAllRequest : IYmiRoutable
{
    protected readonly static string Route = "videos/getall";

    public string BuildRouteFrom()
    {
        return VideosGetAllRequest.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
