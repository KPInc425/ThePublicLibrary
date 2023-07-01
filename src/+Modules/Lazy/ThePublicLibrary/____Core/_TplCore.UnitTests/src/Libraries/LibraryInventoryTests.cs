namespace TplCore.UnitTests;

public class LibraryInventoryTests
{
    [Fact]
    public void LibraryCanHaveAnInventoryOfBooks()
    {
        var library = LibraryTplTestData.FirstStreetLibrary;
        var book = BookTplTestData.BookAlfradoTheGreat;
        
        library.AddBookToInventory(book);
        library.Books.FirstOrDefault(rs => rs.Isbn == book.Isbn && rs.Title == book.Title).Should().NotBeNull();
    }
}
