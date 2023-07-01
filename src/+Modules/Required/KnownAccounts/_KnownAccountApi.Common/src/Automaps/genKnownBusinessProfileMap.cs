// ag=no
namespace KnownAccountsApi.Common.Automaps;
public partial class KnownBusinessProfileMap : Profile
{
    public override string ProfileName
    {
        get { return "KnownBusinessProfileMap"; }
    }

    public KnownBusinessProfileMap()
    {
        CreateMap<KnownBusinessWebsiteProfile, KnownBusinessWebsiteProfileViewModel>(MemberList.None)
        //.ReverseMap()
        ;
    }
}