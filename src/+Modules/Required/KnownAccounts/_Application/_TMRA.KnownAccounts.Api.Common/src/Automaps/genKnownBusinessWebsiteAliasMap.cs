// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownBusinessWebsiteAliasMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownBusinessWebsiteAliasMap"; }
    }
    
    public KnownBusinessWebsiteAliasMap()
    {
        CreateMap<KnownBusinessWebsiteAlias, KnownBusinessWebsiteAliasViewModel>()
        .ReverseMap();
    }
}