namespace YmiCore.TestData.Entities;

public class GameTestData
{
    public static Game TestGame;
    public static Guid TestGameId = new Guid("00000000-0000-0000-0000-000000000002");
    public static Game GameWithPlayerInventory;
    public static Guid GameWithPlayerInventoryId = new Guid("00000000-0000-0000-0000-000000000003");
    public static Game KPsGame;
    public static Guid KPsGameId = new Guid("00000000-0000-0000-0000-000000000001"); 
    public static Game PlayerWithItemsTestGame;
    public static Guid PlayerWithItemsTestGameId = new Guid("00000000-0000-0000-0000-000000000004");
    public static IEnumerable<Game> AllGames;

    static GameTestData()
    {
        var playerA = PlayerTestData.TestPlayer;
        var playerB = PlayerTestData.TestPlayerWithItems;
        var playerC = PlayerTestData.TestPlayer;
        var playerD = PlayerTestData.TestPlayerWithItems;
        TestGame = new Game(TestGameId, playerA);
        // TestGame.GameInit();
        GameWithPlayerInventory = new Game(GameWithPlayerInventoryId, playerB);
        // GameWithPlayerInventory.GameInit();
        KPsGame = new Game(KPsGameId, playerC);
        // KPsGame.GameInit();
        PlayerWithItemsTestGame = new Game(PlayerWithItemsTestGameId, playerD);
        // PlayerWithItemsTestGame.GameInit();

        AllGames = new List<Game> {
            TestGame,
            GameWithPlayerInventory,
            KPsGame,
            PlayerWithItemsTestGame
        };
    }

}
