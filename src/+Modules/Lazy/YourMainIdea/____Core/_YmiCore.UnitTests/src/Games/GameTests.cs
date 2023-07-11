using System.Text.RegularExpressions;
namespace YmiCore.UnitTests;

public class GameTests
{
    private readonly Game gameData = GameTestData.TestGame;
    private readonly Player playerData = PlayerTestData.TestPlayer;
    [Fact]
    public void CanCreateNewGame()
    {
        // Given I have a player with name, bio, description, and background. 
        var playerData = PlayerTestData.TestPlayer;
        // When I create a game 
        var gameA = new Game(playerData);
        // Then game has random values based on player background 
        gameA.PlayerLuck.Should().BeGreaterThan(gameData.DifficultyLevel);
        // And
        // Game has regions and cities, 
        gameA.AllRegions.Count().Should().Be(gameData.AllRegions.Count());
        gameA.CurrentCity.Should().NotBeNull();
        // And player is referenced in game, 
        gameA.Player.Should().NotBeNull();
        // And max days, time of day.
        gameA.CurrentDay.Should().Be(gameData.CurrentDay);
        gameA.MaxDays.Should().Be(gameData.MaxDays);
        gameA.TimeOfDay.Should().Be(gameData.TimeOfDay);
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
    public void GameHasRegionCount()
    {
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has RegionCount
        gameA.RegionCount.Should().Be(gameData.RegionCount);
    }

    [Fact]
    public void GameHasCityCount()
    {
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has CityCount
        gameA.CityCount.Should().Be(gameData.CityCount);
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
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has start location
        gameA.StartLocation.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public void GameStartLocationFollowsConvention()
    {
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // AND I have a city pattern
        var cityPattern = @"City[0-9]{0,3}";
        var cityRegex = new Regex(cityPattern);
        var cityMatch = cityRegex.Match(gameData.StartLocation);
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has start location name follows convention
        cityMatch.Success.Should().BeTrue();
    }

    [Fact]
    public void GameHasDifficultyLevel()
    {
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has difficulty level
        gameA.DifficultyLevel.Should().Be(gameData.DifficultyLevel);

    }

    [Fact]
    public void GameHasPlayerLuck()
    {
        // Given I have Player Data
        var playerData = PlayerTestData.TestPlayer;
        // AND Game Data
        var gameData = GameTestData.TestGame;
        // When I create a game
        var gameA = new Game(playerData);
        // Then game has difficulty level
        gameA.PlayerLuck.Should().BeGreaterThanOrEqualTo(gameData.DifficultyLevel);
    }
}
