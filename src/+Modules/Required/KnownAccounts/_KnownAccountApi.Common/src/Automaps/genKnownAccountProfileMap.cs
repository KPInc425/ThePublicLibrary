// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
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