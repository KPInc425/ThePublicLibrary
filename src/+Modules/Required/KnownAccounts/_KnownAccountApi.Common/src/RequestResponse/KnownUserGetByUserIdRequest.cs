namespace KnownAccountsApi.Common.RequestResponse;
public class KnownUserGetByUserIdRequest
{
    public const string Route = "/api/KnownUser";
    private KnownUserGetByUserIdRequest()
    { }
    public KnownUserGetByUserIdRequest(Guid userId)
    {
        UserId = Guard.Against.NullOrEmpty(userId);
    }

    public Guid UserId { get; set; }
    public static string BuildRoute() => Route;
}
