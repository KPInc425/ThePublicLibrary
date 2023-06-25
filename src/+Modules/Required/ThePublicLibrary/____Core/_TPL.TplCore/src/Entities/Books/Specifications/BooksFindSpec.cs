namespace TPL.TplCore.Entities;
public class BooksFindSpec : Specification<Book>
{
    public BooksFindSpec(string titleSearch, IEnumerable<string>? authorSearch, IEnumerable<string>? categorySearch, IEnumerable<string>? conditionSearch, int? paginationPage = 0, int? paginationTake = int.MaxValue)
    {
        if (!paginationPage.HasValue)
        {
            paginationPage = 0;
        }
        if (!paginationTake.HasValue)
        {
            paginationTake = int.MaxValue;
        }

        if (titleSearch.Trim() != "")
        {
            Query
                .Where(rs => rs.Title.Contains(titleSearch));
        }

        if (authorSearch is not null && authorSearch.Any())
        {
            Query
                .Where(s => s.Authors!.Any(rs => authorSearch
                    .Any(author => rs.Name.ToString()
                        .Contains(author))));
        }

        if (categorySearch is not null && categorySearch.Any())
        {
            Query
                .Where(s => s.BookCategories!.Any(rs => categorySearch
                    .Any(categorySearch => rs.Title
                        .Contains(categorySearch))));
        }

        if (conditionSearch is not null && conditionSearch.Any())
        {
            Query
                .Where(book => book.BookCopies
                    .Any(search => conditionSearch.Any(condition => search.Condition.ToString().Contains(condition))));
        }

        Query
            .OrderBy(rs => rs.Title)
            .Skip(paginationPage.Value * paginationTake.Value)
            .Take(paginationTake.Value)
            ;
    }
}
