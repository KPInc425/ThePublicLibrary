// ag=no
namespace TPL.KnownAccounts.Api.Common.Automaps; 
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