// ag=yes
namespace KnownAccountsApi.Common.Automaps; 
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