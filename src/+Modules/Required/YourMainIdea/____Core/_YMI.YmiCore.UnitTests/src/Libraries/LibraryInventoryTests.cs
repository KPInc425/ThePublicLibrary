namespace YMI.YmiCore.UnitTests;

public class LibraryInventoryTests
{
    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        var library = LibraryYmiTestData.FirstStreetLibrary;
        var book = BookYmiTestData.BookAlfradoTheGreat;
        
        library.AddBookToInventory(book);
        library.Books.FirstOrDefault(rs => rs.Isbn == book.Isbn && rs.Title == book.Title).Should().NotBeNull();
    }
}
