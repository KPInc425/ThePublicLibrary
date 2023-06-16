namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownUserGetRequest
{
    public const string Route = "/api/KnownUser";

    public KnownUserGetRequest()
    { }

    public static string BuildRoute() => Route;
}
