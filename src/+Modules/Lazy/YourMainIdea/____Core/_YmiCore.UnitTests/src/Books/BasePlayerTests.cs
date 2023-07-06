namespace YmiCore.UnitTests;
public abstract class BasePlayerTests
{
    /* protected Player? _playerToTestWith;
    protected List<Player> _playersToTestWith = new();

    protected void ICreateAPlayer(Player player, string reasonMessage = "")
    {
        _playerToTestWith = new Player(
            player.Name,
            player.Description,
            player.Bio,
            player.UpbringingType
        );

        _playerToTestWith.Should().NotBeNull(reasonMessage);

    }
    protected void ICreateManyPlayers(IEnumerable<Player> players, string reasonMessage = "")
    {
        foreach (var player in players)
        {
            var newPlayer = new Player(
                player.Name,
                player.Description,
                player.Bio,
                player.UpbringingType
            );

            newPlayer.Should().NotBeNull(reasonMessage);

        }
        _playersToTestWith.Count().Should().Be(players.Count());
    } */
}