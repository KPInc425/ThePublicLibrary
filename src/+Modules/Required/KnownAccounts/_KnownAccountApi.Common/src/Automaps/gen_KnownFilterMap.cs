// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
public partial class KnownFilterMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownFilterMap"; }
    }
    
    public KnownFilterMap()
    {
        CreateMap<KnownFilter, KnownFilterViewModel>()
        .ReverseMap();
    }
}