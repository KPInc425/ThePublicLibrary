namespace TPL.Infrastructure.CommandQuery;

public class LibrariesGetAllQuery : IRequest<List<Library>>, IRoutable
{
    protected readonly static string Route = "/libraries/all";

    public string BuildRouteFrom()
    {
        return LibrariesGetAllQuery.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
