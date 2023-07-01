// ag=no
namespace KnownAccountsApi.Common.Automaps;
public partial class WebsitePageMap : Profile
{
    public override string ProfileName
    {
        get { return "WebsitePageMap"; }
    }

    public WebsitePageMap()
    {
        CreateMap<WebsitePage, WebsitePageViewModel>();
        CreateMap<WebsitePageViewModel, WebsitePage>()
            .ForMember(src => src.WebsiteChildPages, opt => opt.Ignore())
            .ForMember(src => src.WebsitePageContents, opt => opt.Ignore())
        ;
    }
}