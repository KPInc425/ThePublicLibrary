// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownUserMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownUserMap"; }
    }
    
    public KnownUserMap()
    {
        CreateMap<KnownUser, KnownUserViewModel>()
        .ReverseMap();
    }
}