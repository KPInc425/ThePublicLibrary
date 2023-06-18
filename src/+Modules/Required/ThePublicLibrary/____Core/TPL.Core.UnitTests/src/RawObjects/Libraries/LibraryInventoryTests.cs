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
}
