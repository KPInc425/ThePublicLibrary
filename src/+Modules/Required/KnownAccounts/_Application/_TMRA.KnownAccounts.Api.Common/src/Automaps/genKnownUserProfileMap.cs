// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownUserProfileMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownUserProfileMap"; }
    }
    
    public KnownUserProfileMap()
    {
        CreateMap<KnownUserProfile, KnownUserProfileViewModel>()
        .ReverseMap();
    }
}