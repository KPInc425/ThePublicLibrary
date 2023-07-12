namespace YmiCore.TestData.Entities;
public static class PlayerTestData
{
    public static Player TestPlayer;
    public static Player TestPlayerWithItems;
    public static IEnumerable<Player> AllPlayers;


    static PlayerTestData()
    {
        TestPlayer = new Player("George");
        AllPlayers = new List<Player> {
            TestPlayer,
            TestPlayer,
            TestPlayer,
            TestPlayer,
            TestPlayer
        };
        TestPlayerWithItems = new Player("George");
        TestPlayerWithItems.AddItemToStorage(StorageItemTestData.AlternateTestItem);
        TestPlayerWithItems.AddManyItemsToStorage(StorageItemTestData.ManyItems);
    }
}
