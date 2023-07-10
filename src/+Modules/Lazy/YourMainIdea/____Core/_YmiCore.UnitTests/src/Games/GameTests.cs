using System.Text.RegularExpressions;
namespace YmiCore.UnitTests;

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

    [Fact]
    public void GameHasDayProperties()
    {
        // Given I have a Data
        var playerData = PlayerTestData.TestPlayer;
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has max days, current day, and time of day
        gameA.CurrentDay.Should().Be(gameData.CurrentDay);
        gameA.MaxDays.Should().Be(gameData.MaxDays);
        gameA.TimeOfDay.Should().Be(gameData.TimeOfDay);
    }
    [Fact]
    public void GameHasStartLocation()
    {
        // Given I have a Data
        var playerData = PlayerTestData.TestPlayer;
        var gameData = GameTestData.TestGame;
        // AND I have a city pattern
        var cityPattern = @"City[0-9]{0,3}";
        var cityRegex = new Regex(cityPattern);
        var cityMatch = cityRegex.Match(gameData.StartLocation);
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has start location
        gameA.StartLocation.Should().NotBeNullOrEmpty();
        cityMatch.Success.Should().BeTrue();

    }
}
