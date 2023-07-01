// ag=yes
namespace KnownAccountsInfrastructure.Commands; 
public partial class KnownBusinessAddChildBusinessCmd : IRequest<KnownBusiness>
{
    private KnownBusinessAddChildBusinessCmd()
    {}
    public KnownBusinessAddChildBusinessCmd(Guid existingBusinessId, KnownBusiness childBusiness)
    {
        ExistingBusinessId = Guard.Against.NullOrEmpty(existingBusinessId, nameof(existingBusinessId));
        ChildBusiness = Guard.Against.Null(childBusiness, nameof(childBusiness));
    }
    public Guid ExistingBusinessId { get; set; }
    public KnownBusiness ChildBusiness { get; set; }
}
