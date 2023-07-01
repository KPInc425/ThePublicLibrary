// ag=yes
namespace KnownAccountsInfrastructure.Commands; 
public partial class KnownBusinessWebsiteUpdateCmd : IRequest<KnownBusinessWebsite>
{
    private KnownBusinessWebsiteUpdateCmd() { }
    public KnownBusinessWebsiteUpdateCmd(KnownBusinessWebsite website)
    {
        KnownBusinessWebsite = website;    
    }
    public KnownBusinessWebsite KnownBusinessWebsite { get; set; }
}
