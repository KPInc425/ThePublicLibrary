namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownBusinessGetByIdRequest
{
    public const string Route = "/api/KnownBusinessGetById?Url={guid:id}";

    [Required]
    public Guid Id { get; set; }

    private KnownBusinessGetByIdRequest() { }
    public KnownBusinessGetByIdRequest(Guid id)
    {
        Id = id;
    }

    public static string BuildRoute(Guid id) => Route.Replace("{guid:id}", id.ToString());
}
