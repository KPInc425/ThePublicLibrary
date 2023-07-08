namespace YmiCore.UnitTests;

public class PlayerConstructorTests
{

    [Fact]
    public void CanCreatePlayer()
    {
        // Given I have a player with name, bio, description, and background.
        var playerData = PlayerTestData.TestPlayer;

        // When I create the player
        var playerA = new Player(playerData.Name, playerData.Description, playerData.Bio, playerData.UpbringingType);

        // Then I have a player with name, bio, description, and background values
        playerA.Name.Should().Be(playerData.ToString());
        playerA.Name.Should().Be(playerData.Name);
        playerA.Description.Should().Be(playerData.Description);
        playerA.Bio.Should().Be(playerData.Bio);
        playerA.UpbringingType.Should().Be(playerData.UpbringingType);
        
        // And the player has a random {insert here}
    }
}