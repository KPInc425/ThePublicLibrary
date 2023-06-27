namespace YMI.YmiCore.Entities;
public class VideosFindSpec : Specification<Video>
{
    public VideosFindSpec(string titleSearch, IEnumerable<string>? actorSearch, IEnumerable<string>? categorySearch, IEnumerable<string>? conditionSearch, int? paginationPage = 0, int? paginationTake = int.MaxValue)
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

        if (actorSearch is not null && actorSearch.Any())
        {
            Query
                .Where(s => s.Actors!.Any(rs => actorSearch
                    .Any(actor => rs.Name.ToString()
                        .Contains(actor))));
        }

        if (categorySearch is not null && categorySearch.Any())
        {
            Query
                .Where(s => s.VideoCategories!.Any(rs => categorySearch
                    .Any(categorySearch => rs.Title
                        .Contains(categorySearch))));
        }

        if (conditionSearch is not null && conditionSearch.Any())
        {
            Query
                .Where(video => video.VideoCopies
                    .Any(search => conditionSearch.Any(condition => search.Condition.ToString().Contains(condition))));
        }

        Query
            .OrderBy(rs => rs.Title)
            .Skip(paginationPage.Value * paginationTake.Value)
            .Take(paginationTake.Value)
            ;
    }
}
