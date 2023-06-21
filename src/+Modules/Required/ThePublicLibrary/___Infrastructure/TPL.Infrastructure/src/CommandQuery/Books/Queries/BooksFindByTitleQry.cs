namespace TPL.Infrastructure.CommandQuery;

public class BooksFindByTitleQry : IRequest<List<Book>>, IRoutable
{
    protected readonly static string Route = "/books/findbytitle/?searchFor={searchFor}";

    [Required]
    public string SearchFor { get; set; }

    public BooksFindByTitleQry(string searchFor)
    {
        SearchFor = searchFor;
    }

    public string BuildRouteFrom()
    {
        return BooksFindByTitleQry.BuildRoute(SearchFor);
    }
    public static string BuildRoute(string searchFor) { return Route.Replace("{searchFor}", searchFor); }
}
