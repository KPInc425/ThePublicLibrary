namespace KnownAccountsApi.Common.RequestResponse;
public class KnownBusinessGetChildBusinessesRequest
{
    public const string Route = "/api/KnownBusinessGetById?Id={guid:id}";

    [Required]
    public Guid Id { get; set; }

    private KnownBusinessGetChildBusinessesRequest() { }
    public KnownBusinessGetChildBusinessesRequest(Guid id)
    {
        Id = id;
    }

    public static string BuildRoute(Guid id) => Route.Replace("{guid:id}", id.ToString());
}
