namespace TPL.Infrastructure.CommandQuery;

public class BooksGetAllQry : IRequest<List<Book>>, IRoutable
{
    protected readonly static string Route = "books/getall";

    public string BuildRouteFrom()
    {
        return BooksGetAllQry.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
