namespace YmiCore.YmiTestData.Entities;
public static class GameTestData
{
    public static Player TestPlayer;

    public static IEnumerable<Player> AllPlayers;

    static GameTestData()
    {
        TestPlayer = new Player("George", bio: "ABS" );
        AllPlayers = new List<Player> {
            TestPlayer
        };
    }
}
