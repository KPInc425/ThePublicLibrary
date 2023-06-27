namespace YMI.YmiInfrastructure.CommandQuery;

public class VideosFindQry : IRequest<List<Video>>
{
    public string TitleSearch { get; set; }
    public IEnumerable<string> ActorSearch { get; set; }
    public IEnumerable<string> CategorySearch { get; set; }
    public IEnumerable<string> ConditionSearch { get; set; }

    public VideosFindQry(string titleSearch, IEnumerable<string> actorSearch, IEnumerable<string> categorySearch, IEnumerable<string> conditionSearch)
    {
        TitleSearch = titleSearch;
        ActorSearch = actorSearch;
        CategorySearch = categorySearch;
        ConditionSearch = conditionSearch;
    }
}
