namespace YMI.YmiCore.YmiTestData.Requests;
public class BooksFindYmiTestData : IYmiTestData
{
    public BooksFindSpec FindByTitleSpec { get; set; }
    public BooksFindSpec FindByTitleAndAuthorsSpec { get; set; }
    public BooksFindSpec FindByTitleAndAuthorsAndCategoriesSpec { get; set; }

    public IEnumerable<BooksFindSpec> AllBooksFindSpecs { get; set; }

    public BooksFindYmiTestData()
    {
        FindByTitleSpec = new BooksFindSpec("alf", null, null, null);
        FindByTitleAndAuthorsSpec = new BooksFindSpec("a", new List<string> { "a" }, null, null);
        FindByTitleAndAuthorsAndCategoriesSpec = new BooksFindSpec("a", new List<string> { "a" }, new List<string> { "a" }, null);

        AllBooksFindSpecs = new List<BooksFindSpec> {
            FindByTitleSpec,
            FindByTitleAndAuthorsSpec,
            FindByTitleAndAuthorsAndCategoriesSpec
        };
    }
}
