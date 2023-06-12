namespace TPL.Core.UnitTests;

public class LibraryInventoryTests
{
    private readonly LibraryTestData _libraryTestData = new();
    private readonly BookTestData _bookTestData = new();

    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        var library = _libraryTestData.FirstStreetLibrary;
        var book = _bookTestData.AlfradoTheGreat;

        library.AddBookToInventory(book);
        library.Books.FirstOrDefault(rs => rs.ISBN == book.ISBN && rs.Title == book.Title).Should().NotBeNull();
    }

    [Fact]
    public void LibraryCanHaveMultipleCopiesOfTheSameBook()
    {
        // Given I have a library
        // When I add books to its inventory
        // And I add additional copies of the same book to its inventory
        // Then the Library should have books in its inventory
        // And the library should have duplicate books in its inventory

        // ARRANGE
        var library = _libraryTestData.FirstStreetLibrary;
        var books = _bookTestData.AllBooks;

        // ACT
        library.AddBookToInventory(books);

        // ASSERT
        library.Books.Count(rs => rs.ISBN == BookTestData.ISBNx3).Should().Be(2);

    }

    [Fact]
    public void LibraryCanRemoveDamagedBooksFromTheInventory()
    {
        // Given I have a library
        // And the library has books in its inventory
        // When I remove a damaged book from the inventory
        // Then the library should be missing the damaged book

        // ARRANGE
        var library = _libraryTestData.FirstStreetLibrary;

        var books = _bookTestData.AllBooks;

        // ACT
        library.AddBookToInventory(books);

        // ASSERT
        library.Books.Count().Should().Be(books.Count());

        var randomBook = library.Books.FirstOrDefault();
        library.RemoveBook(randomBook);
        library.Books.Count().Should().Be(books.Count() - 1);
    }
}
