// ag=no
namespace KnownAccountsApi.Common.Automaps; 
public partial class KnownBusinessMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownBusinessMap"; }
    }
    
    public KnownBusinessMap()
    {
        CreateMap<KnownBusiness, KnownBusinessViewModel>()
        //.ReverseMap()
        ;
    }
}