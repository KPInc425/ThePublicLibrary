namespace YmiCore.TestData.Entities;

public class GameTestData
{
    public static Game TestGame;

    public static IEnumerable<Game> AllGames;

    static GameTestData()
    {
        var playerA = PlayerTestData.TestPlayer;
        TestGame = new Game(playerA);

        AllGames = new List<Game> {
            TestGame,
        };
    }

}
