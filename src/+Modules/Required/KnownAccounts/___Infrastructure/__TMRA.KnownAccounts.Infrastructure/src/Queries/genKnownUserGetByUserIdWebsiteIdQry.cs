// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Queries; 
public partial class KnownUserGetByUserIdWebsiteIdQry : IRequest<KnownUser>
{
    private KnownUserGetByUserIdWebsiteIdQry()
    { }
    public KnownUserGetByUserIdWebsiteIdQry(Guid knownUserId, Guid knownBusinessWebsiteId)
    {
        KnownUserId = Guard.Against.NullOrEmpty(knownUserId);
        KnownBusinessWebsiteId = knownBusinessWebsiteId;
    }
    public Guid KnownUserId { get; set; }
    public Guid KnownBusinessWebsiteId { get; set; }
}
