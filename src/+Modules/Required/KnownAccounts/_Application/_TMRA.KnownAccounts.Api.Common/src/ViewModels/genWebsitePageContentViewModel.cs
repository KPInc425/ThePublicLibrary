// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class WebsitePageContentViewModel : ViewModelBase<Guid>
{ 

     public WebsitePageViewModel WebsitePage { get; set; }
     [MaxLength(65535)]
     public string HtmlContent { get; set; } = "";

} 
        