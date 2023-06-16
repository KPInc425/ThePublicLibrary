// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class KnownBusinessWebsiteAliasViewModel : ViewModelBase<Guid>
{ 

     public KnownBusinessWebsiteViewModel KnownBusinessWebsite { get; set; }
     public string Url { get; set; } = String.Empty;
     public string Name { get; set; } = String.Empty;
     public bool IsActive { get; set; } = true;

} 
        