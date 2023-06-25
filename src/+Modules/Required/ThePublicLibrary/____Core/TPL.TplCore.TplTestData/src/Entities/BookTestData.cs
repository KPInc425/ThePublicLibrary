namespace TPL.TplCore.TplTestData.Entities;
public static class BookTplTestData
{
    public static Book BookTheWildSide;
    public static Book BookJumpingForJax;
    public static Book BookJuniperRising;
    public static Book BookAlfradoTheGreat;
    public static Book BookManyCopies;
    public static Book BookNoCopies;
    public static Book BookWithCategories;
    public static Book BookOfThreeAuthors;
    public static Book BookOfFantasy;
    

    public static BookCategory BookCategoryFiction;
    public static BookCategory BookCategoryNonFiction;
    public static BookCategory BookCategoryScify;
    public static BookCategory BookCategoryFantasy;

    public static IEnumerable<Book> AllBooks;

    static BookTplTestData()
    {
        BookCategoryFiction = new("Fiction");
        BookCategoryNonFiction = new("Non-Fiction");
        BookCategoryScify = new("Scify");
        BookCategoryFantasy = new("Fantasy");

        BookTheWildSide = new(new("978-0-00-000000-6"), new List<Author>() { AuthorTplTestData.AuthorJohnWriter }, null, null, "The Wild Side", 1982, 100);
        BookTheWildSide.AddBookCopy(BookCondition.Poor);
        BookTheWildSide.AddBookCopy(BookCondition.Good);

        BookJumpingForJax = new(new("978-0-00-000000-7"), new List<Author>() { AuthorTplTestData.AuthorSallyTyper }, null, null, "Jumping for Jax", 1983, 200);
        BookJumpingForJax.AddBookCopy(BookCondition.Good);

        BookJuniperRising = new(new("978-0-00-000000-8"), new List<Author>() { AuthorTplTestData.AuthorBishopKnight }, null, null, "Juniper Rising", 1984, 300);
        BookJuniperRising.AddBookCopy(BookCondition.Good);

        BookAlfradoTheGreat = new(new("978-0-00-000000-9"), new List<Author>() { AuthorTplTestData.AuthorJohnWriter }, null, null, "Alfrado The Great", 1985, 400);
        BookAlfradoTheGreat.AddBookCopy(BookCondition.Good);

        BookNoCopies = new(new("978-0-00-000441-1"), new List<Author>() { AuthorTplTestData.AuthorSallyTyper }, null, null, "Book No Copies", 1981, 110);

        BookManyCopies = new(new("978-0-00-000001-1"), new List<Author>() { AuthorTplTestData.AuthorSallyTyper }, null, null, "Book Many Copies", 1981, 110);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);
        BookManyCopies.AddBookCopy(BookCondition.Good);

        BookOfThreeAuthors = new(new("978-0-00-000331-2"), new List<Author> { AuthorTplTestData.AuthorBishopKnight, AuthorTplTestData.AuthorJohnWriter, AuthorTplTestData.AuthorSallyTyper }, null, null, "Book of Three Authors", 1981, 120);

        BookWithCategories = new(new("978-0-00-000131-1"), new List<Author> { AuthorTplTestData.AuthorSallyTyper }, new List<BookCategory> { BookCategoryFantasy, BookCategoryFiction }, null, "Book With Categories", 1981, 110);
        BookWithCategories.AddBookCopy(BookCondition.Good);
        BookWithCategories.AddBookCopy(BookCondition.Fair);
        BookWithCategories.AddBookCopy(BookCondition.Poor);
        
        BookOfFantasy = new(new("978-0-00-000131-1"), new List<Author> { AuthorTplTestData.AuthorSallyTyper }, new List<BookCategory> { BookCategoryFantasy }, null, "Book Of Fantasy", 1981, 110);


        AllBooks = new List<Book> {
            BookTheWildSide,
            BookJumpingForJax,
            BookJuniperRising,
            BookAlfradoTheGreat,
            BookManyCopies,
            BookNoCopies,
            BookWithCategories,
            BookOfThreeAuthors,
            BookOfFantasy
        };
    }
}
