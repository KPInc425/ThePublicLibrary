// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownUserProfileMap : Profile
{ 
    public override string ProfileName => "KnownUserProfileMap";
    
    public KnownUserProfileMap()
    {
        CreateMap<KnownUserProfile, KnownUserProfileViewModel>()
        .ReverseMap();
    }
}