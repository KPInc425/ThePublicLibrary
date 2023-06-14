namespace TPL.Infrastructure.CommandQuery;
public class BookAddCommand : IRequest<Book>, IRoutable
{
    protected static string Route = "/book/add";
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    public List<Author> Authors { get; set; }
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    public BookAddCommand(string isbn, string title, List<Author> authors, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Authors = authors;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }
    public BookAddCommand(Book book)
    {
        Isbn = book.Isbn.ToString();
        Title = book.Title;
        PublicationYear = book.PublicationYear;
        PageCount = book.PageCount;

        foreach(var author in book.BookAuthors)
        {
            Authors.Add(author.Author);
        }
    }
    public string BuildRouteFrom() {
        return BookAddCommand.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
