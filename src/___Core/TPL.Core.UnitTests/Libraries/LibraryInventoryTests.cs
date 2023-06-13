namespace TPL.Core.UnitTests;

public class LibraryInventoryTests
{
    private readonly LibraryTestData _libraryTestData = new();
    private readonly BookTestData _bookTestData = new();

    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        var library = _libraryTestData.FirstStreetLibrary;
        var book = _bookTestData.BookAlfradoTheGreat;

        library.AddBookToInventory(book);
        library.Books.FirstOrDefault(rs => rs.Isbn == book.Isbn && rs.Title == book.Title).Should().NotBeNull();
    }

    [Fact]
    public void LibraryCanHaveMultipleCopiesOfTheSameBook()
    {
        // Given I have a library and books
        var library = _libraryTestData.FirstStreetLibrary;
        var books = _bookTestData.AllBooks;

        // When I add books to the library
        library.AddBookToInventory(books);
        
        // Then the Library should have books in its inventory
        library.Books.Count().Should().Be(_bookTestData.AllBooks.Count());
    }

    [Fact]
    public void LibraryCanRemoveDamagedBooksFromTheInventory()
    {
        // Given I have a library and books
        var library = _libraryTestData.FirstStreetLibrary;
        var books = _bookTestData.AllBooks;

        // And the library has books in its inventory
        library.AddBookToInventory(books);
        library.Books.Count().Should().Be(books.Count());

        // When I select a random book 
        var randomBook = library.Books.FirstOrDefault(rs=>rs.BookCopies.Count() > 1);
        randomBook.Should().NotBeNull();

        // And I select the first book copy
        var randomBookCopy = randomBook.BookCopies.FirstOrDefault();
        randomBook.BookCopies.Count().Should().BeGreaterThan(1);

        // And I store the number of copies plus one to offset the index
        var numberOfCopies = randomBook.BookCopies.Count();

        // When I remove the damaged copy
        randomBook.RemoveBookCopy(randomBookCopy);

        // Then I should have one fewer copies of the book
        randomBook.BookCopies.Count().Should().Be(numberOfCopies - 1);
    }
}
