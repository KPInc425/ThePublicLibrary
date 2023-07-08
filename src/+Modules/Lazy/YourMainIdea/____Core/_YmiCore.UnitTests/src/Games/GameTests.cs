namespace YmiCore.UnitTests
{
    public class GameTests
    {
        [Fact]
        public void CanCreateNewGame()
        {
            // Given I have a player with name, bio, description, and background. 
            // AND 
            // When I create a game 
            // Then game has random values based on player background 
            // AND
            // Game has regions, cities, and connected player, max days, time of day.
        }

        [Fact]
        public void GameHasCurrentCity()
        {
            // Given I have a Player Data
            var playerData = PlayerTestData.TestPlayer;
            // When I create a game
            var gameA = new Game(playerData);
            // Then game has a current city
            gameA.CurrentCity.Should().NotBeNull();
        }

        [Fact]
        public void GameHasRegions()
        {
            // Given I have a Data
            var playerData = PlayerTestData.TestPlayer;
            var gameData = GameTestData.TestGame;
            // When I create a game
            var gameA = new Game(playerData);
            // Then game has a current city
            gameA.AllRegions.Count().Should().Be(gameData.AllRegions.Count());
        }
    }
}