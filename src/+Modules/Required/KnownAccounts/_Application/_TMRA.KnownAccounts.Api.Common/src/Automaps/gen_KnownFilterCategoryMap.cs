// ag=yes
namespace TPL.KnownAccounts.Api.Common.Automaps; 
public partial class KnownFilterCategoryMap : Profile
{ 
    public override string ProfileName 
    {
        get { return "KnownFilterCategoryMap"; }
    }
    
    public KnownFilterCategoryMap()
    {
        CreateMap<KnownFilterCategory, KnownFilterCategoryViewModel>()
        .ReverseMap();
    }
}