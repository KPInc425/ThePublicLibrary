namespace YMI.YmiApplication.Shared.Requests;

public class VideosFindRequest : IYmiRoutable
{
    protected readonly static string Route = "/videos/find?titleSearch{string:titleSearch}&{actorSearchParamArray}{categorySearchParamArray}{conditionSearchParamArray}";

    public string TitleSearch { get; set; }
    public IEnumerable<string> ActorSearch { get; set; }
    public IEnumerable<string> CategorySearch { get; set; }
    public IEnumerable<string> ConditionSearch { get; set; }

    public VideosFindRequest(string titleSearch, IEnumerable<string> actorSearch, IEnumerable<string> categorySearch, IEnumerable<string> conditionSearch)
    {
        TitleSearch = titleSearch;
        ActorSearch = actorSearch;
        CategorySearch = categorySearch;
        ConditionSearch = conditionSearch;
    }

    public string BuildRouteFrom()
    {
        return BuildRoute(TitleSearch, ActorSearch, CategorySearch, ConditionSearch);
    }
    public static string BuildRoute(VideosFindQry qry) {
        return BuildRoute(qry.TitleSearch, qry.ActorSearch, qry.CategorySearch, qry.ConditionSearch);
    }
    public static string BuildRoute(string titleSearch, IEnumerable<string> actorSearch, IEnumerable<string> categorySearch, IEnumerable<string> conditionSearch)
    {
        return Route.Replace("{titleSearch}", titleSearch)
            .Replace("{actorSearchParamArray}", actorSearch is not null ? $"&actorSearch={string.Join("&actorSearch=", actorSearch)}" : "")
            .Replace("{categorySearchParamArray}", categorySearch is not null ? $"&categorySearch={string.Join("&categorySearch=", categorySearch)}" : "")
            .Replace("{conditionSearchParamArray}", conditionSearch is not null ? $"&conditionSearch={string.Join("&conditionSearch=", conditionSearch)}" : "");
    }
}
