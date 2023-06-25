namespace TPL.TplInfrastructure.CommandQuery;

public class BooksFindQry : IRequest<List<Book>>
{
    public string TitleSearch { get; set; }
    public IEnumerable<string> AuthorSearch { get; set; }
    public IEnumerable<string> CategorySearch { get; set; }
    public IEnumerable<string> ConditionSearch { get; set; }

    public BooksFindQry(string titleSearch, IEnumerable<string> authorSearch, IEnumerable<string> categorySearch, IEnumerable<string> conditionSearch)
    {
        TitleSearch = titleSearch;
        AuthorSearch = authorSearch;
        CategorySearch = categorySearch;
        ConditionSearch = conditionSearch;
    }
}
