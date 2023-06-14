namespace TPL.Infrastructure.CommandQuery;

public class MembershipsFindByNameQuery : IRequest<List<Membership>>, IRoutable
{
    protected static string Route = "/memberships/{searchFor}";
    
    [Required]
    public string SearchFor { get; set; }

    public MembershipsFindByNameQuery(string searchFor)
    {
        SearchFor = searchFor;
    }

    public string BuildRouteFrom() {
        return MembershipsFindByNameQuery.BuildRoute(SearchFor);
    }
    public static string BuildRoute(string searchFor) { return Route.Replace("{searchFor}", searchFor); }
}
