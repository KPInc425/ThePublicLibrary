namespace TPL.Infrastructure.CommandQuery;

public class MembersFindByNameQuery : IRequest<List<Member>>, IRoutable
{
    protected readonly static string Route = "/members/find/{searchFor}";
    
    [Required]
    public string SearchFor { get; set; }

    public MembersFindByNameQuery(string searchFor)
    {
        SearchFor = searchFor;
    }

    public string BuildRouteFrom() {
        return MembersFindByNameQuery.BuildRoute(SearchFor);
    }
    public static string BuildRoute(string searchFor) { return Route.Replace("{searchFor}", searchFor); }
}
