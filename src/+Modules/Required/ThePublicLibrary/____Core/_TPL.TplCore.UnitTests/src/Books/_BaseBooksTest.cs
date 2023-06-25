namespace TPL.TplCore.UnitTests;
public abstract class BaseBooksTest
{
    protected IsbnVO? _bookIsbn;
    protected Book? _bookToTestWith;
    protected List<Book> _booksToTestWith = new();
    protected BookCopy? _bookCopyToTestWith;
    protected List<Author>? _bookAuthorsToTestWith;
    protected List<BookCategory>? _bookCategoriesToTestWith;

    protected void ICreateABook(Book book)
    {
        _bookToTestWith = new Book(
            book.Isbn,
            book.Authors,
            book.BookCategories,
            book.BookCopies,
            book.Title,
            book.PublicationYear,
            book.PageCount);

        _bookToTestWith.Should().NotBeNull();
        _bookToTestWith.Isbn.Should().Be(book.Isbn);
        _bookToTestWith.Authors.Count().Should().Be(book.Authors.Count());
        _bookToTestWith.BookCategories.Count().Should().Be(book.BookCategories.Count());
        _bookToTestWith.BookCopies.Count().Should().Be(book.BookCopies.Count());
        _bookToTestWith.Title.Should().Be(book.Title);
        _bookToTestWith.PublicationYear.Should().Be(book.PublicationYear);
        _bookToTestWith.PageCount.Should().Be(book.PageCount);
    }
    protected void ICreateManyBooks(IEnumerable<Book> books)
    {
        foreach (var book in books)
        {
            var newBook = new Book(
                book.Isbn,
                book.Authors,
                book.BookCategories,
                book.BookCopies,
                book.Title,
                book.PublicationYear,
                book.PageCount);

            newBook.Should().NotBeNull();
            newBook.Isbn.Should().Be(book.Isbn);
            newBook.Authors.Count().Should().Be(book.Authors.Count());
            newBook.BookCategories.Count().Should().Be(book.BookCategories.Count());
            newBook.BookCopies.Count().Should().Be(book.BookCopies.Count());
            newBook.Title.Should().Be(book.Title);
            newBook.PublicationYear.Should().Be(book.PublicationYear);
            newBook.PageCount.Should().Be(book.PageCount);
            _booksToTestWith.Add(newBook);
        }
        _booksToTestWith.Count().Should().Be(books.Count());
    }
    protected void IHaveABookCopyOfCondition(BookCondition condition)
    {
        _bookCopyToTestWith = _bookToTestWith.BookCopies.FirstOrDefault(rs => rs.Condition == condition);
        _bookCopyToTestWith.Should().NotBeNull();
        _bookCopyToTestWith.Condition.Should().Be(BookCondition.Good);

    }
    protected void IHaveBookCategories()
    {
        if (_bookToTestWith.BookCategories.Count() == 0)
        {
            _bookToTestWith.AddBookCategory(BookTplTestData.BookCategoryFiction);
            _bookToTestWith.AddBookCategory(BookTplTestData.BookCategoryFantasy);
        }
    }
}
