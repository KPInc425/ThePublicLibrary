namespace YmiCore.YmiTestData.Entities;
public static class PlayerTestData
{
    public static Player TestPlayer;

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
    }
}
