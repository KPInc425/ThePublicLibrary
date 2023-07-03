namespace AccountModuleApplication.Shared.Interfaces;

public partial interface IAccountModuleDataService
{
    
    Task<KnownBusinessWebsiteViewModel> KnownBusinessWebsiteGet();
    Task<WebsitePageViewModel> WebsitePageGetByUrl(WebsitePageGetByUrlRequest request);
    Task<WebsitePageViewModel> WebsitePageUpdate(WebsitePageUpdateRequest request);

    Task KnownBusinessWebsiteProfileUpdateAsync(KnownBusinessWebsiteProfileUpdateRequest request);
    Task KnownBusinessWebsiteUpdateAsync(KnownBusinessWebsiteUpdateRequest request);
}