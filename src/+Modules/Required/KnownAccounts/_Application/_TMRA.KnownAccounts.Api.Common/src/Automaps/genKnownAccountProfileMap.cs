// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownAccountProfileMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownAccountProfileMap"; }
    }
    
    public KnownAccountProfileMap()
    {
        CreateMap<KnownAccountProfile, KnownAccountProfileViewModel>()
        .ReverseMap();
    }
}