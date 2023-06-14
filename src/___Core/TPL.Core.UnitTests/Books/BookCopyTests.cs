namespace TPL.Core.UnitTests.Books
{
    public class BookCopyTests
    {
        private readonly BookTestData _bookTestData = new();

        [Fact]
        public void LibraryCanHaveMultipleCopiesOfTheSameBook()
        {
            // Given I have a book with no copies
            var book = _bookTestData.BookNoCopies;
            book.BookCopies.Should().BeEmpty();

            // When I add a book copy
            book.AddBookCopy(BookCondition.Good);

            // Then there should be on copy of the book
            book.BookCopies.Should().NotBeEmpty();
            book.BookCopies.Count().Should().Be(1);
        }
    }
}