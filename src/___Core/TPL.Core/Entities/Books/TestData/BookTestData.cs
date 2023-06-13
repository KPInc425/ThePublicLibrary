namespace TPL.Core.Entities.TestData;
public class BookTestData : ITestData
{
    public readonly Book BookTheWildSide;
    public readonly Book BookJumpingForJax;
    public readonly Book BookJuniperRising;
    public readonly Book BookAlfradoTheGreat;

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

        AllBooks = new List<Book> {
            BookTheWildSide,
            BookJumpingForJax,
            BookJuniperRising,
            BookAlfradoTheGreat
        };
    }
}
