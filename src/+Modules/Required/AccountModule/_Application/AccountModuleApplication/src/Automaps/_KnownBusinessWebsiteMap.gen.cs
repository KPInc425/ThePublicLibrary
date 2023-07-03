// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownBusinessWebsiteMap : Profile
{ 
    public override string ProfileName => "KnownBusinessWebsiteMap";
    
    public KnownBusinessWebsiteMap()
    {
        CreateMap<KnownBusinessWebsite, KnownBusinessWebsiteViewModel>()
        .ReverseMap();
    }
}