namespace YMI.YmiInfrastructure.CommandQuery;

public class VideosFindByTitleQry : IRequest<List<Video>>
{
    protected readonly static string Route = "/videos/findbytitle/?searchFor={searchFor}";

    [Required]
    public string SearchFor { get; set; }

    public VideosFindByTitleQry(string searchFor)
    {
        SearchFor = searchFor;
    }
}
