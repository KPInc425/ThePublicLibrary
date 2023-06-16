namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownBusinessAddChildBusinessRequest
{
    public const string Route = "/api/KnownBusiness";

    private KnownBusinessAddChildBusinessRequest()
    {}
    public KnownBusinessAddChildBusinessRequest(Guid existingBusinessId, KnownBusiness childBusiness)
    {
        ExistingBusinessId = Guard.Against.NullOrEmpty(existingBusinessId, nameof(existingBusinessId));
        ChildBusiness = Guard.Against.Null(childBusiness, nameof(childBusiness));
    }

    public static string BuildRoute => Route;

    public Guid ExistingBusinessId { get; set; }
    public KnownBusiness ChildBusiness { get; set; }
}

