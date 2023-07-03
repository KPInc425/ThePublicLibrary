// ag=yes
namespace AccountModuleCore..Api.Common.Automaps; 
public partial class KnownUserMap : Profile
{ 
    public override string ProfileName => "KnownUserMap";
    
    public KnownUserMap()
    {
        CreateMap<KnownUser, KnownUserViewModel>()
        .ReverseMap();
    }
}