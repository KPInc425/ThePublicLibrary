namespace TPL.Infrastructure.CommandQuery;

public class BooksGetAllQuery : IRequest<List<Book>>, IRoutable
{
    protected readonly static string Route = "books/getall";

    public string BuildRouteFrom()
    {
        return BooksGetAllQuery.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
