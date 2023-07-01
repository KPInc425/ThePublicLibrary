// ag=yes
namespace KnownAccountsInfrastructure.Queries; 
public partial class KnownUserGetByUserIdQry : IRequest<KnownUser>
{
    private KnownUserGetByUserIdQry()
    { }
    public KnownUserGetByUserIdQry(Guid userId)
    {
        UserId = Guard.Against.NullOrEmpty(userId);
    }
    public Guid UserId { get; set; }
}
