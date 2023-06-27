namespace YMI.YmiCore.YmiTestData.Entities;
public static class VideoStoreYmiTestData
{
    public static string FirstStreetVideoStoreName = "First Street VideoStore";
    public static VideoStore FirstStreetVideoStore;
    public static PhysicalAddyVO FirstStreetVideoStoreAddress = new (
        "123 First Street",
        "Suite 100",
        "First City",
        "First State",
        "12345",
        "First Country"
    );

    public static string SecondStreetVideoStoreName = "Second Street VideoStore";
    public static VideoStore SecondStreetVideoStore;
    public static PhysicalAddyVO SecondStreetVideoStoreAddress = new (
        "456 Second Street",
        "Suite 200",
        "Second City",
        "Second State",
        "67890",
        "Second Country"
    );

    public static IEnumerable<VideoStore> AllVideoStores;

    static VideoStoreYmiTestData()
    {
        FirstStreetVideoStore = new VideoStore(FirstStreetVideoStoreName, FirstStreetVideoStoreAddress);
        SecondStreetVideoStore = new VideoStore(SecondStreetVideoStoreName, SecondStreetVideoStoreAddress);

        AllVideoStores = new List<VideoStore> {
            FirstStreetVideoStore,
            SecondStreetVideoStore
        };
    }
}
