namespace TPL.Infrastructure.CommandQuery;
public class BookAddCommand : IRequest<Book>, IRoutable
{
    protected static string Route = "/book/add";
    [Required]
    public string Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    public List<Author> Authors { get; set; } = new();
    public List<BookCopy> BookCopies { get; set; } = new();
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    public BookAddCommand(string isbn, string title, List<Author> authors, List<BookCopy> bookCopies, int publicationYear, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Authors = authors;
        BookCopies = bookCopies;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }
    public BookAddCommand(Book book)
    {
        Isbn = book.Isbn.ToString();
        Title = book.Title;
        PublicationYear = book.PublicationYear;
        PageCount = book.PageCount;

        Authors.AddRange(book.Authors);

        if (book.BookCopies is not null)
        {
            BookCopies.AddRange(book.BookCopies);
        }

    }
    public string BuildRouteFrom()
    {
        return BookAddCommand.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
