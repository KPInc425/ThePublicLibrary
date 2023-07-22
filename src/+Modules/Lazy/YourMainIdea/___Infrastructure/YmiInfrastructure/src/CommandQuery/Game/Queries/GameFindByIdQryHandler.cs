namespace YmiInfrastructure.CommandQuery;

public class GameFindByIdQryHandler : IRequestHandler<GameFindByIdQry, Game>
{
    private readonly IRepository<Game> _repository;
    public GameFindByIdQryHandler(IRepository<Game> repository)
    {
        _repository = repository;
    }
    public async Task<Game> Handle(GameFindByIdQry qry, CancellationToken cancellationToken)
    {
        var gameGetByIdSpec = new GameGetByIdSpec(qry.Id);
        return await _repository.FirstOrDefaultAsync(gameGetByIdSpec, cancellationToken);
    }
}