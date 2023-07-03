// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownBusinessWebsiteAliasMap : Profile
{ 
    public override string ProfileName => "KnownBusinessWebsiteAliasMap";
    
    public KnownBusinessWebsiteAliasMap()
    {
        CreateMap<KnownBusinessWebsiteAlias, KnownBusinessWebsiteAliasViewModel>()
        .ReverseMap();
    }
}