namespace YmiCore.Entities;
public class Game : BaseEntityTracked<Guid>, IAggregateRoot
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int DifficultyLevel { get; private set; }
    public int RegionCount { get; private set; }
    public int CityCount { get; private set; }
    public int Luck { get; private set; }

    private readonly List<GameInstance> _gameInstances = new();

    public IEnumerable<GameInstance> GameInstances => _gameInstances.AsReadOnly();


    private Game() { }
    public Game(string title)
    {
        Title = title;
    }
    public override string ToString()
    {
        return Title.ToString();
    }
}
