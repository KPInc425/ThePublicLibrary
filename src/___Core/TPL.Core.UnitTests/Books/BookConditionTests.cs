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
}