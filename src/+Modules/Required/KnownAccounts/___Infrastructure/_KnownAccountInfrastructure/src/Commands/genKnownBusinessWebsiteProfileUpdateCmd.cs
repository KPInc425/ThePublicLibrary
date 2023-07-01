// ag=yes
namespace KnownAccountsInfrastructure.Commands; 
public partial class KnownBusinessWebsiteProfileUpdateCmd : IRequest<KnownBusinessWebsiteProfile>
{
    private KnownBusinessWebsiteProfileUpdateCmd() { }
    public KnownBusinessWebsiteProfileUpdateCmd(KnownBusinessWebsiteProfile knownBusinessWebsiteProfile)
    {
        KnownBusinessWebsiteProfile = knownBusinessWebsiteProfile;
    }
    public KnownBusinessWebsiteProfile KnownBusinessWebsiteProfile { get; set; }
}
