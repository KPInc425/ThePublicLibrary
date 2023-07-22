using System.Text.RegularExpressions;
namespace YmiCore.UnitTests;

public class GameSearchTest
{
    [Fact]
    [Trait("SearchGames", "GetById")]
    public void CanSearchGames()
    {
        // Give I have a list of games
        var games = GameTestData.AllGames;
        // When I search by gameId
        var gameFindByIdSpec = new GameGetByIdSpec(GameTestData.KPsGameId);
        var gameResult = gameFindByIdSpec.Evaluate(games).FirstOrDefault();
        // Then I get a game
        gameResult.Should().NotBeNull();
        gameResult.Id.Should().Be(GameTestData.KPsGameId);
    }
}