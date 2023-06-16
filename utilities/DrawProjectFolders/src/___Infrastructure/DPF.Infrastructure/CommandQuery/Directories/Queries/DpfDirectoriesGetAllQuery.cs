namespace Dpf.Infrastructure.CommandQuery;

public class DpfDirectoriesGetAllQuery : IRequest<List<DpfDirectory>>, IRoutable
{
    protected readonly static string Route = "directories/getall";

    public string BuildRouteFrom()
    {
        return DpfDirectoriesGetAllQuery.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
