// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownAccountMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownAccountMap"; }
    }
    
    public KnownAccountMap()
    {
        CreateMap<KnownAccount, KnownAccountViewModel>()
        .ReverseMap();
    }
}