namespace YMI.YmiCore.Entities;
public class ActorsFindByTitleSpec : Specification<Actor>
{
    public ActorsFindByTitleSpec(string searchString)
    {
        Query
            .Where(s => s.Name.ToString().Contains(searchString))
            .OrderBy(s => s.Name.ToString());
    }
}
