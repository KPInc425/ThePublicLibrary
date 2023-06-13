
namespace TPL.Core.UnitTests;

public class BookConstructorTests
{
    private readonly BookTestData _bookTestData = new();

    [Fact]
    public void BookConstructorTest()
    {
        // Given I have a book
        var book = new Book(
            _bookTestData.BookAlfradoTheGreat.Isbn,
            _bookTestData.BookAlfradoTheGreat.Title,
            _bookTestData.BookAlfradoTheGreat.Author,
            _bookTestData.BookAlfradoTheGreat.PublicationYear,
            _bookTestData.BookAlfradoTheGreat.PageCount);

        // And I add 3 book copies
        book.AddBookCopy(1, BookCondition.Good);
        book.AddBookCopy(2, BookCondition.Good);
        book.AddBookCopy(3, BookCondition.Poor);

        // Then the book is not null
        book.Should().NotBeNull();

        // And the book has a title
        book.Title.Should().Be(_bookTestData.BookAlfradoTheGreat.Title);

        // And the book has an author
        book.Author.Should().Be(_bookTestData.BookAlfradoTheGreat.Author);

        // And the book has an ISBN
        book.Isbn.Should().Be(_bookTestData.BookAlfradoTheGreat.Isbn);

        // And the book has a publication year
        book.PublicationYear.Should().Be(_bookTestData.BookAlfradoTheGreat.PublicationYear);

        // And the book has a page count
        book.PageCount.Should().Be(_bookTestData.BookAlfradoTheGreat.PageCount);

        // And the book has 2 good condition copies
        book.BookCopies.Count(rs => rs.Condition == BookCondition.Good).Should().Be(2);

        // And the book has 1 poor condition copy
        book.BookCopies.Count(rs => rs.Condition == BookCondition.Poor).Should().Be(1);
    }
}