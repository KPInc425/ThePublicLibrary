namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownAccountGetAllRequest //List
{
    public const string Route = "/api/KnownAccounts";

    public KnownAccountGetAllRequest()
    {
    }

    public static string BuildRoute() => Route;
}
