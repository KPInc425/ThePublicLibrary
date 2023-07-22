namespace YmiInfrastructure.CommandQuery;

public class GameFindByIdQry : IRequest<Game>
{
    public Guid Id { get; set; }


    public GameFindByIdQry(Guid id)
    {
        Id = id;
    }
}
