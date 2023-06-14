namespace TPL.Core.UnitTests.Specs;

[Binding]
public class LibraryInventorySpec
{
    private readonly Book _book1 = new("978-0-00-000000-1", "Book 1");
    private readonly Book _book2 = new("978-0-00-000000-2", "Book 2");
    private readonly Book _book3 = new("978-0-00-000000-3", "Book 3");

    private Library _library;

    [Given(@"I have a library")]
    public void GivenIHaveALibrary()
    {
        _library = new Library("My awesome library");
    }

    [When(@"I add books to the library")]
    public void WhenIAddBooksToItsInventory()
    {
        var books = new List<Book>() {
            _book2,
            _book3
        };
        _library.AddBookToInventory(_book1);
        _library.AddBookToInventory(books);                
    }

    [Then(@"the Library should have books in its inventory")]
    public void ThenTheLibraryShouldHaveBooksInItsInventory()
    {
        _library.Books.Count().Should().Be(3);

        _library.Books.FirstOrDefault(rs => rs.Isbn == _book1.Isbn && rs.Title == _book1.Title).Should().NotBeNull();
        _library.Books.FirstOrDefault(rs => rs.Isbn == _book2.Isbn && rs.Title == _book2.Title).Should().NotBeNull();
        _library.Books.FirstOrDefault(rs => rs.Isbn == _book3.Isbn && rs.Title == _book3.Title).Should().NotBeNull();
    }
}