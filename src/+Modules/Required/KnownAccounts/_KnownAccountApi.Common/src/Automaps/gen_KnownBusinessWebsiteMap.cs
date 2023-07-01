// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
public partial class KnownBusinessWebsiteMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownBusinessWebsiteMap"; }
    }
    
    public KnownBusinessWebsiteMap()
    {
        CreateMap<KnownBusinessWebsite, KnownBusinessWebsiteViewModel>()
        .ReverseMap();
    }
}