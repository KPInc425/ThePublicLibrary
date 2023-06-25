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
                .Where(rs => rs.Title.Contains(titleSearch, StringComparison.OrdinalIgnoreCase));
        }

        if (authorSearch is not null)
        {
            Query
                .Where(s => s.Authors!.Any(rs => authorSearch
                    .Any(author => rs.Name.ToString()
                        .Contains(author, StringComparison.OrdinalIgnoreCase))));
        }

        if (categorySearch is not null)
        {
            Query
                .Where(s => s.BookCategories!.Any(rs => categorySearch
                    .Any(categorySearch => rs.Title
                        .Contains(categorySearch, StringComparison.OrdinalIgnoreCase))));
        }

        if (conditionSearch is not null)
        {
            Query
                .Where(book => book.BookCopies
                    .Any(search => conditionSearch.Any(_ => search.Condition.ToString().Contains(search.Condition.ToString(), StringComparison.OrdinalIgnoreCase))));
        }

        Query
            .OrderBy(rs => rs.Title)
            .Skip(paginationPage.Value * paginationTake.Value)
            .Take(paginationTake.Value)
            ;
    }
}
