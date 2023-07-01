// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class KnownUserProfileViewModel : ViewModelBase<Guid>
{ 

     [MaxLength(101)]
     public string Name { get; set; } = String.Empty;
     public Guid KnownUserId { get; set; } = Guid.Empty;
     public KnownUserViewModel KnownUser { get; set; }
     public Guid KnownBusinessWebsiteId { get; set; } = Guid.Empty;
     public KnownBusinessWebsiteViewModel KnownBusinessWebsite { get; set; }

} 
        