namespace TPL.Core.UnitTests;

public class LibraryInventoryTests
{
    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        var library = LibraryTestData.FirstStreetLibrary;
        var book = BookTestData.BookAlfradoTheGreat;
        
        library.AddBookToInventory(book);
        library.Books.FirstOrDefault(rs => rs.Isbn == book.Isbn && rs.Title == book.Title).Should().NotBeNull();
    }
}
