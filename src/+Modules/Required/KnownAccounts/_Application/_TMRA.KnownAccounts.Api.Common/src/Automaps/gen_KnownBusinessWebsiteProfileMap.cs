// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownBusinessWebsiteProfileMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownBusinessWebsiteProfileMap"; }
    }
    
    public KnownBusinessWebsiteProfileMap()
    {
        CreateMap<KnownBusinessWebsiteProfile, KnownBusinessWebsiteProfileViewModel>()
        .ReverseMap();
    }
}