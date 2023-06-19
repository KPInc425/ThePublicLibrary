using System.Collections.Generic;

namespace TPL.Core.TestData.Entities;
public class BookTestData : ITestData
{
    public readonly Book BookTheWildSide;
    public readonly Book BookJumpingForJax;
    public readonly Book BookJuniperRising;
    public readonly Book BookAlfradoTheGreat;
    public readonly Book BookManyCopies;
    public readonly Book BookNoCopies;
    public readonly Book BookWithCategories;
    public readonly Book BookOfThreeAuthors;

    public readonly BookCategory BookCategoryFiction;
    public readonly BookCategory BookCategoryNonFiction;
    public readonly BookCategory BookCategoryScify;
    public readonly BookCategory BookCategoryFantasy;

    public readonly IEnumerable<Book> AllBooks;

    private readonly AuthorTestData _authorTestData = new();

    public BookTestData()
    {
        BookCategoryFiction = new("Fiction");
        BookCategoryNonFiction = new("Non-Fiction");
        BookCategoryScify = new("Scify");
        BookCategoryFantasy = new("Fantasy");

        BookTheWildSide = new(new("978-0-00-000000-6"), new List<Author>() { _authorTestData.AuthorJohnWriter }, null, null, "The Wild Side", 1982, 100);
        BookTheWildSide.AddBookCopy(BookCondition.Poor);
        BookTheWildSide.AddBookCopy(BookCondition.Good);

        BookJumpingForJax = new(new("978-0-00-000000-7"), new List<Author>() { _authorTestData.AuthorSallyTyper }, null, null, "Jumping for Jax", 1983, 200);
        BookJumpingForJax.AddBookCopy(BookCondition.Good);

        BookJuniperRising = new(new("978-0-00-000000-8"), new List<Author>() { _authorTestData.AuthorBishopKnight }, null, null, "Juniper Rising", 1984, 300);
        BookJuniperRising.AddBookCopy(BookCondition.Good);

        BookAlfradoTheGreat = new(new("978-0-00-000000-9"), new List<Author>() { _authorTestData.AuthorJohnWriter }, null, null, "Alfrado The Great", 1985, 400);
        BookAlfradoTheGreat.AddBookCopy(BookCondition.Good);

        BookNoCopies = new(new("978-0-00-000441-1"), new List<Author>() { _authorTestData.AuthorSallyTyper }, null, null, "Book Many Copies", 1981, 110);

        BookManyCopies = new(new("978-0-00-000001-1"), new List<Author>() { _authorTestData.AuthorSallyTyper }, null, null, "Book Many Copies", 1981, 110);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);

        BookOfThreeAuthors = new(new("978-0-00-000331-2"), new List<Author> { _authorTestData.AuthorBishopKnight, _authorTestData.AuthorJohnWriter, _authorTestData.AuthorSallyTyper }, null, null, "Book of Three Authors", 1981, 120);

        BookWithCategories = new(new("978-0-00-000131-1"), new List<Author> { _authorTestData.AuthorSallyTyper }, new List<BookCategory> { BookCategoryFantasy, BookCategoryFiction }, null, "Book With Categories", 1981, 110);
        BookWithCategories.AddBookCopy(BookCondition.Good);
        BookWithCategories.AddBookCopy(BookCondition.Fair);
        BookWithCategories.AddBookCopy(BookCondition.Poor);
        

        AllBooks = new List<Book> {
            BookTheWildSide,
            BookJumpingForJax,
            BookJuniperRising,
            BookAlfradoTheGreat,
            BookManyCopies,
            BookNoCopies,
            BookWithCategories,
            BookOfThreeAuthors
        };
    }
}
