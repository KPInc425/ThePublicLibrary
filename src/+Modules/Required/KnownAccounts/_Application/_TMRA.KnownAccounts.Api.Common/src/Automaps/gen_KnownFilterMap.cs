// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
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