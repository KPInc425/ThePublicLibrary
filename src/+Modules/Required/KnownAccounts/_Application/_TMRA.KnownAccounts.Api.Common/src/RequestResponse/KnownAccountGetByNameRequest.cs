namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownAccountGetByNameRequest
{
    public const string Route = "/api/KnownAccount?AccountName={string:name}";

    [Required]
    public string Name { get; set; }

    private KnownAccountGetByNameRequest() { }
    public KnownAccountGetByNameRequest(string name)
    {
        Name = name;
    }

    public static string BuildRoute(string name) => Route.Replace("{string:name}", name);
}
