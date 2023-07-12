namespace YmiCore.TestData.Entities;

public class GameTestData
{
    public static Game TestGame;
    public static Game PlayerWithItemsTestGame;

    public static IEnumerable<Game> AllGames;

    static GameTestData()
    {
        var playerA = PlayerTestData.TestPlayer;
        var playerB = PlayerTestData.TestPlayerWithItems;
        TestGame = new Game(playerA);
        PlayerWithItemsTestGame = new Game(playerB);

        AllGames = new List<Game> {
            TestGame,
        };
    }

}
