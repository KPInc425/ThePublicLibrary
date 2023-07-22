namespace YmiCore.TestData.Entities;

public class GameTestData
{
    public static Game TestGame;
    public static Game GameWithPlayerInventory;
    public static Game KPsGame;
    public static Guid KPsGameId = new Guid("00000000-0000-0000-0000-000000000001"); 
    public static Game PlayerWithItemsTestGame;
    public static IEnumerable<Game> AllGames;

    static GameTestData()
    {
        var playerA = PlayerTestData.TestPlayer;
        var playerB = PlayerTestData.TestPlayerWithItems;
        TestGame = new Game(playerA);
        GameWithPlayerInventory = new Game(playerB);
        KPsGame = new Game(KPsGameId, playerA);
        PlayerWithItemsTestGame = new Game(playerB);

        AllGames = new List<Game> {
            TestGame,
            GameWithPlayerInventory,
            KPsGame,
            PlayerWithItemsTestGame
        };
    }

}
