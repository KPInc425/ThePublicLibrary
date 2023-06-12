using TPL.Core.Entities.TestData;

namespace TPL.Core.Tests.Specs;

[Binding]
public class LibraryInventorySpec
{
    private readonly LibraryTestData _libraryTestData = new();
    private readonly BookTestData _bookTestData = new();
    private Library _library;

    [Given(@"I have a library")]
    public void GivenIHaveALibrary()
    {
        _library = _libraryTestData.FirstStreetLibrary;
    }

    [When(@"I add books to the library")]
    public void WhenIAddBooksToItsInventory()
    {
        foreach (var book in _bookTestData.AllBooks)
        {
            _library.AddBookToInventory(book);
        }
    }

    [Then(@"the Library should have books in its inventory")]
    public void ThenTheLibraryShouldHaveBooksInItsInventory()
    {
        _library.Books.Count().Should().Be(_bookTestData.AllBooks.Count());
        foreach (var book in _bookTestData.AllBooks)
        {
            _library.Books.FirstOrDefault(rs => rs.ISBN == book.ISBN && rs.Title == book.Title).Should().NotBeNull();
        }
    }
}