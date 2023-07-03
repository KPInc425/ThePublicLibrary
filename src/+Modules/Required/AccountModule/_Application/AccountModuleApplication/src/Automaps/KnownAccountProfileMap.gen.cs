// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownAccountProfileMap : Profile
{ 
    public override string ProfileName => "KnownAccountProfileMap";
    
    public KnownAccountProfileMap()
    {
        CreateMap<KnownAccountProfile, KnownAccountProfileViewModel>()
        .ReverseMap();
    }
}