namespace TPL.Infrastructure.CommandQuery;

public class MembershipsGetAllQuery : IRequest<List<Membership>>, IRoutable
{
    protected static string Route = "/members";
    
    public string BuildRouteFrom() {
        return MembershipsGetAllQuery.BuildRoute();
    }
    public static string BuildRoute() { return $"api/members"; }
}
