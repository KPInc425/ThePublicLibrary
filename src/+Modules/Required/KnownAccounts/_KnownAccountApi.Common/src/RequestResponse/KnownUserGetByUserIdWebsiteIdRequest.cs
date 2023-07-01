namespace KnownAccountsApi.Common.RequestResponse;
public class KnownUserGetByUserIdWebsiteIdRequest
{
    public const string Route = "/api/KnownUser";
    private KnownUserGetByUserIdWebsiteIdRequest()
    { }
    public KnownUserGetByUserIdWebsiteIdRequest(Guid knownUserId, Guid knownBusinessWebsiteId)
    {
        KnownUserId = Guard.Against.NullOrEmpty(knownUserId);
        KnownBusinessWebsiteId = knownBusinessWebsiteId;
    }

    public Guid KnownUserId { get; set; }
    public Guid KnownBusinessWebsiteId { get; set; }
    public static string BuildRoute() => Route;
}
