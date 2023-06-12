namespace TPL.Infrastructure.CommandQuery;

public class BooksFindByTitleQuery : IRequest<List<Book>>, IRoutable
{
    protected readonly static string Route = "/Books/find/{searchFor}";

    [Required]
    public string SearchFor { get; set; }

    public BooksFindByTitleQuery(string searchFor)
    {
        SearchFor = searchFor;
    }

    public string BuildRouteFrom()
    {
        return BooksFindByTitleQuery.BuildRoute(SearchFor);
    }
    public static string BuildRoute(string searchFor) { return Route.Replace("{searchFor}", searchFor); }
}
