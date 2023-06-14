using System.Linq;
namespace TPL.Core.Tests;

public class LibraryInventoryTests
{
    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        // Given I have a library
        // When I add books to its inventory
        // Then the Library should have books in its inventory

        // ARRANGE
        var library = new Library("TPL Library");
        var book = new Book("595.701", "Happy days part one");

        // ACT
        library.AddBookToInventory(book);

        // ASSERT
        library.Books.FirstOrDefault(rs => rs.Isbn == book.Isbn && rs.Title == book.Title).Should().NotBeNull();
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
        var library = new Library("TPL Library");
        var books = new List<Book>() {
            new Book("595.701", "Happy days part one"),
            new Book("595.702", "Happy days part two"),
            new Book("595.702", "Happy days part two"),
            new Book("595.703", "Happy days part three"),
            new Book("595.704", "Happy days part four"),
            new Book("595.705", "Happy days part five")
        };
        
        // ACT
        library.AddBookToInventory(books);
        
        // ASSERT
        library.Books.Count(rs=>rs.Isbn == "595.702").Should().Be(2);
        
    }

    [Fact]
    public void LibraryCanRemoveDamagedBooksFromTheInventory()
    {
        // Given I have a library
        // And the library has books in its inventory
        // When I remove a damaged book from the inventory
        // Then the library should be missing the damaged book

        // ARRANGE
        var library = new Library("TPL Library");
        
        var books = new List<Book>() {
            new Book("595.701", "Happy days part one"),
            new Book("595.702", "Happy days part two"),
            new Book("595.703", "Happy days part three"),
            new Book("595.704", "Happy days part four"),
            new Book("595.705", "Happy days part five")
        };
        
        // ACT
        library.AddBookToInventory(books);
        
        // ASSERT
        library.Books.Count().Should().Be(5);
        
        var randomBook = library.Books.FirstOrDefault();        
        library.RemoveBook(randomBook);        
        library.Books.Count().Should().Be(4);
    }
}
