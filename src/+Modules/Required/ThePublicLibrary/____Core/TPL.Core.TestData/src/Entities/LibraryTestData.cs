namespace TPL.Core.TestData.Entities;
public static class LibraryTestData
{
    public static string FirstStreetLibraryName = "First Street Library";
    public static Library FirstStreetLibrary;
    public static PhysicalAddressVO FirstStreetLibraryAddress = new (
        "123 First Street",
        "Suite 100",
        "First City",
        "First State",
        "12345",
        "First Country"
    );

    public static string SecondStreetLibraryName = "Second Street Library";
    public static Library SecondStreetLibrary;
    public static PhysicalAddressVO SecondStreetLibraryAddress = new (
        "456 Second Street",
        "Suite 200",
        "Second City",
        "Second State",
        "67890",
        "Second Country"
    );

    public static IEnumerable<Library> AllLibraries;

    static LibraryTestData()
    {
        FirstStreetLibrary = new Library(FirstStreetLibraryName, FirstStreetLibraryAddress);
        SecondStreetLibrary = new Library(SecondStreetLibraryName, SecondStreetLibraryAddress);

        AllLibraries = new List<Library> {
            FirstStreetLibrary,
            SecondStreetLibrary
        };
    }
}
