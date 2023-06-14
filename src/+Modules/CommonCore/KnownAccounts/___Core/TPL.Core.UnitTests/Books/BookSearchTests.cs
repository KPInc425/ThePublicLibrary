namespace TPL.Core.UnitTests;

public class BookSearchTests
{
    private readonly BookTestData _bookTestData = new();

    [Fact]
    public void CanSearchBooksByYearRange()
    {
        // Given I have books
        var books = _bookTestData.AllBooks;

        // Given I have a search by year range specification
        var startYear = 1900;
        var endYear = 2020;

        var searchByYearRangeSpec = new BooksFindByYearRangeSpec(startYear, endYear);

        // When I search for books in that range
        var booksInRange = searchByYearRangeSpec.Evaluate(books);

        // Then I find books in that range
        booksInRange.Should().NotBeEmpty();
        booksInRange.Should().HaveCountGreaterThan(0);

    }

    [Fact]
    public void CanRemoveDamagedBookCopies()
    {
        // Given I have a book with multiple copies
        var manyCopiesMax = _bookTestData.BookManyCopies;
        manyCopiesMax.Should().NotBeNull();

        // And I select the first book copy
        var randomBookCopy = manyCopiesMax.BookCopies.FirstOrDefault();
        manyCopiesMax.BookCopies.Count().Should().BeGreaterThan(1);

        // And I store the number of copies plus one to offset the index
        var numberOfCopies = manyCopiesMax.BookCopies.Count();

        // When I remove the damaged copy
        manyCopiesMax.RemoveBookCopy(randomBookCopy);

        // Then I should have one fewer copies of the book
        manyCopiesMax.BookCopies.Count().Should().Be(numberOfCopies - 1);
    }
}