namespace TPL.Core.UnitTests;

public class BookConditionTests
{
    private readonly BookTestData _bookTestData = new();

    [Fact]
    public void CanChangeBookCondition()
    {
        // Given I have a book
        var book = _bookTestData.BookTheWildSide;
        book.Should().NotBeNull();

        // And I select a copy that is in good condition
        var bookCopy = book.BookCopies.FirstOrDefault(rs => rs.Condition == BookCondition.Good);
        bookCopy.Should().NotBeNull();
        bookCopy.Condition.Should().Be(BookCondition.Good);

        // When I change the condition to poor
        bookCopy.SetCondition(BookCondition.Poor);

        // Then the book is now in poor condition
        bookCopy.Condition.Should().Be(BookCondition.Poor);
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