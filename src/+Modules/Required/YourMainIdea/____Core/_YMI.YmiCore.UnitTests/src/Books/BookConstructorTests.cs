
namespace YMI.YmiCore.UnitTests;

public class BookConstructorTests : BaseBooksTest
{
    [Fact]
    public void CanCreateBook()
    {
        // When I create a test book
        ICreateABook(BookYmiTestData.BookAlfradoTheGreat);

        // Then the test book has the correct data
        _bookToTestWith.Should().NotBeNull();
    }

    [Fact]
    public void CanCreateBookWithCopies()
    {
        // When I create a book with many copies
        ICreateABook(BookYmiTestData.BookManyCopies);

        // And test book has the correct book copies
        _bookToTestWith.BookCopies.Count().Should().Be(BookYmiTestData.BookManyCopies.BookCopies.Count());

    }

    [Fact]
    public void CanCreateBookWithCategories()
    {
        // When I set test data to a book with categories
        ICreateABook(BookYmiTestData.BookWithCategories);

        // Then book has the correct book categories
        _bookToTestWith.BookCategories.Count().Should().Be(BookYmiTestData.BookWithCategories.BookCategories.Count());
    }
}