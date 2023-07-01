
namespace TplCore.UnitTests;

public class BookConstructorTests : BaseBooksTest
{
    private string _reason = "";
    [Fact]
    public void CanCreateBook()
    {
        _reason = "because BookAlfradoTheGreat should exist";
        // When I create a test book
        base.ICreateABook(BookTplTestData.BookAlfradoTheGreat, _reason);

        // Then the test book has the correct data
        base._bookToTestWith.Should().NotBeNull(_reason);
    }

    [Fact]
    public void CanCreateBookWithCopies()
    {
        _reason = "because BookManyCopies should exist";
        // When I create a book with many copies
        base.ICreateABook(BookTplTestData.BookManyCopies, _reason);

        // And test book has the correct book copies
        base._bookToTestWith!.BookCopies.Count().Should().Be(BookTplTestData.BookManyCopies.BookCopies.Count(), _reason);
    }

    [Fact]
    public void CanCreateBookWithCategories()
    {
        _reason = "because BookManyCopies should exist";
        // When I set test data to a book with categories
        base.ICreateABook(BookTplTestData.BookWithCategories, _reason);

        // Then book has the correct book categories
        base._bookToTestWith.Should().NotBeNull(_reason);
        base._bookToTestWith!.BookCategories.Should().NotBeNull(_reason);
        
        base._bookToTestWith!.BookCategories!.Count().Should().Be(BookTplTestData.BookWithCategories.BookCategories!.Count());
    }

    [Fact]
    public void CanCreateAllTheBooksInOurTestDataset()
    {
        // When I create a test book
        base.ICreateManyBooks(BookTplTestData.AllBooks);

        // Then the test book has the correct data
        base._booksToTestWith.Count().Should().Be(BookTplTestData.AllBooks.Count());
    }
}