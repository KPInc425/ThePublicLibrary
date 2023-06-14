using System.Collections.Generic;

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
        BookTheWildSide = new(new("978-0-00-000000-6"), new List<Author>() { _authorTestData.AuthorJohnWriter }, "The Wild Side", 1982, 100);
        BookTheWildSide.AddBookCopy(BookCondition.Poor);
        BookTheWildSide.AddBookCopy(BookCondition.Good);

        BookJumpingForJax = new(new("978-0-00-000000-7"), new List<Author>() { _authorTestData.AuthorSallyTyper }, "Jumping for Jax", 1983, 200);
        BookJumpingForJax.AddBookCopy(BookCondition.Good);

        BookJuniperRising = new(new("978-0-00-000000-8"), new List<Author>() { _authorTestData.AuthorBishopKnight }, "Juniper Rising", 1984, 300);
        BookJuniperRising.AddBookCopy(BookCondition.Good);

        BookAlfradoTheGreat = new(new("978-0-00-000000-9"), new List<Author>() { _authorTestData.AuthorJohnWriter }, "Alfrado The Great", 1985, 400);
        BookAlfradoTheGreat.AddBookCopy(BookCondition.Good);

        BookManyCopies = new(new("978-0-00-000001-1"), new List<Author>() { _authorTestData.AuthorSallyTyper }, "Book Many Copies", 1981, 110);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);

        BookNoCopies = new(new("978-0-00-000001-2"), new List<Author>() { _authorTestData.AuthorBishopKnight }, "Book No Copies", 1981, 120);

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
