namespace TPL.Core.Entities.TestData;
public class BookTestData : ITestData
{
    public readonly Book BookTheWildSide;
    public readonly Book BookJumpingForJax;
    public readonly Book BookJuniperRising;
    public readonly Book BookAlfradoTheGreat;
    public readonly Book BookManyCopies;
    public readonly Book BookNoCopies;

    public readonly IEnumerable<Book> AllBooks;

    private readonly AuthorTestData _authorTestData = new();

    public BookTestData()
    {
        BookTheWildSide = new(new("978-0-00-000000-6"), "The Wild Side", _authorTestData.AuthorJohnWriter, 1982, 100);
        BookTheWildSide.AddBookCopy(1, BookCondition.Poor);
        BookTheWildSide.AddBookCopy(2, BookCondition.Good);

        BookJumpingForJax = new(new("978-0-00-000000-7"), "Jumping for Jax", _authorTestData.AuthorSallyTyper, 1983, 200);
        BookJumpingForJax.AddBookCopy(1, BookCondition.Good);

        BookJuniperRising = new(new("978-0-00-000000-8"), "Juniper Rising", _authorTestData.AuthorBishopKnight, 1984, 300);
        BookJuniperRising.AddBookCopy(1, BookCondition.Good);

        BookAlfradoTheGreat = new(new("978-0-00-000000-9"), "Alfrado The Great", _authorTestData.AuthorJohnWriter, 1985, 400);
        BookAlfradoTheGreat.AddBookCopy(1, BookCondition.Good);

        BookManyCopies = new(new("978-0-00-000001-1"), "Book Many Copies", _authorTestData.AuthorSallyTyper, 1981, 110);
        BookManyCopies.AddBookCopy(1, BookCondition.Good);
        BookManyCopies.AddBookCopy(2, BookCondition.Good);
        BookManyCopies.AddBookCopy(3, BookCondition.Good);
        BookManyCopies.AddBookCopy(4, BookCondition.Good);
        BookManyCopies.AddBookCopy(5, BookCondition.Good);
        BookManyCopies.AddBookCopy(6, BookCondition.Good);
        BookManyCopies.AddBookCopy(7, BookCondition.Good);

        BookNoCopies = new(new("978-0-00-000001-2"), "Book No Copies", _authorTestData.AuthorBishopKnight, 1981, 120);        

        AllBooks = new List<Book> {
            BookTheWildSide,
            BookJumpingForJax,
            BookJuniperRising,
            BookAlfradoTheGreat,
            BookManyCopies,
            BookNoCopies
        };
    }
}
