namespace TPL.Infrastructure.CommandQuery;
public class BookAddCommand : IRequest<Book>, IRoutable
{
    protected static string Route = "/book/add";
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    public BookCondition Condition { get; set; }
    public BookAddCommand(string isbn, string title)
    {
        Isbn = isbn;
        Title = title;
    }
    public BookAddCommand(Book book)
    {
        Isbn = book.ISBN;
        Title = book.Title;
        Condition = book.Condition;
    }
    public BookAddCommand(string isbn, string title, BookCondition condition): this(isbn, title)
    {
        Condition = condition;
    }

    public string BuildRouteFrom() {
        return BookAddCommand.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
