
namespace TPL.Core.UnitTests;

public class BookConstructorTests : BaseBooksTest
{
    [Fact]
    public void CanCreateBook()
    {
        // When I create a test book
        ICreateABook(BookTestData.BookAlfradoTheGreat);

        // Then the test book has the correct data
        _bookToTestWith.Should().NotBeNull();
    }

    [Fact]
    public void CanCreateBookWithCopies()
    {
        // When I create a book with many copies
        ICreateABook(BookTestData.BookManyCopies);

        // And test book has the correct book copies
        _bookToTestWith.BookCopies.Count().Should().Be(BookTestData.BookManyCopies.BookCopies.Count());

    }

    [Fact]
    public void CanCreateBookWithCategories()
    {
        // When I set test data to a book with categories
        ICreateABook(BookTestData.BookWithCategories);

        // Then book has the correct book categories
        _bookToTestWith.BookCategories.Count().Should().Be(BookTestData.BookWithCategories.BookCategories.Count());
    }
}