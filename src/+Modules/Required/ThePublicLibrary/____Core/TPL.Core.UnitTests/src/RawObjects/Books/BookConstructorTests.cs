
namespace TPL.Core.UnitTests;

public class BookConstructorTests : BooksBaseTest
{
    [Fact]
    public void CanCreateBook()
    {
        // When I create a test book
        ICreateABook(_bookTestData.BookAlfradoTheGreat);

        // Then the test book has the correct data
        _bookToTestWith.Should().NotBeNull();
    }

    [Fact]
    public void CanCreateBookWithCopies()
    {
        // When I create a book with many copies
        ICreateABook(_bookTestData.BookManyCopies);

        // And test book has the correct book copies
        _bookToTestWith.BookCopies.Count().Should().Be(_bookTestData.BookManyCopies.BookCopies.Count());

    }

    [Fact]
    public void CanCreateBookWithCategories()
    {
        // When I set test data to a book with categories
        ICreateABook(_bookTestData.BookWithCategories);

        // Then book has the correct book categories
        _bookToTestWith.BookCategories.Count().Should().Be(_bookTestData.BookWithCategories.BookCategories.Count());
    }
}