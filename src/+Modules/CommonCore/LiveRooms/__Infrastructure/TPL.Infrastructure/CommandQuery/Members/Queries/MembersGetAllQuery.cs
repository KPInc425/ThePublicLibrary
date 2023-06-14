namespace TPL.Infrastructure.CommandQuery;

public class MembersGetAllQuery : IRequest<List<Member>>, IRoutable
{
    protected readonly static string Route = "/members/all";
    
    public string BuildRouteFrom() {
        return MembersGetAllQuery.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
