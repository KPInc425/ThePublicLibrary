namespace TPL.Core.Entities.TestData;
public class LibraryTestData {
    public readonly string FirstStreetLibraryName = "First Street Library";
    public readonly Library FirstStreetLibrary;

    public readonly string SecondStreetLibraryName = "Second Street Library";
    public readonly Library SecondStreetLibrary;

    public LibraryTestData(BookTestData bookTestData) {
        FirstStreetLibrary = new Library(FirstStreetLibraryName);
        SecondStreetLibrary = new Library(SecondStreetLibraryName);
        
        FirstStreetLibrary.AddBookToInventory(bookTestData.TheWildSideGoodCondition);
        FirstStreetLibrary.AddBookToInventory(bookTestData.TheWildSidePoorCondition);
        FirstStreetLibrary.AddBookToInventory(bookTestData.JumpingForJax);
        
        SecondStreetLibrary.AddBookToInventory(bookTestData.JuniperRising);
        SecondStreetLibrary.AddBookToInventory(bookTestData.AlfradoTheGreat);
    }      
}
