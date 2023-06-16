// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownUserFilterMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownUserFilterMap"; }
    }
    
    public KnownUserFilterMap()
    {
        CreateMap<KnownUserFilter, KnownUserFilterViewModel>()
        .ReverseMap();
    }
}