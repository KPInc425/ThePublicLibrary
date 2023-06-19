namespace TPL.Core.TestData.Entities;
public class LibraryTestData : ITestData
{
    public readonly string FirstStreetLibraryName = "First Street Library";
    public readonly Library FirstStreetLibrary;
    public readonly PhysicalAddressVO FirstStreetLibraryAddress = new (
        "123 First Street",
        "Suite 100",
        "First City",
        "First State",
        "12345",
        "First Country"
    );

    public readonly string SecondStreetLibraryName = "Second Street Library";
    public readonly Library SecondStreetLibrary;
    public readonly PhysicalAddressVO SecondStreetLibraryAddress = new (
        "456 Second Street",
        "Suite 200",
        "Second City",
        "Second State",
        "67890",
        "Second Country"
    );

    public readonly IEnumerable<Library> AllLibraries;

    public LibraryTestData()
    {
        FirstStreetLibrary = new Library(FirstStreetLibraryName, FirstStreetLibraryAddress);
        SecondStreetLibrary = new Library(SecondStreetLibraryName, SecondStreetLibraryAddress);

        AllLibraries = new List<Library> {
            FirstStreetLibrary,
            SecondStreetLibrary
        };
    }
}
