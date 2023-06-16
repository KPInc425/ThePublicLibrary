// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class KnownUserViewModel : ViewModelBase<Guid>
{ 

     [MaxLength(100)]
     public string? Name { get; set; } = "";
     public Guid UserId { get; set; } = Guid.Empty;
     [MaxLength(100)]
     public string? EmailAddress { get; set; } = null;
     public DateTime? LastAgreedToTOS { get; set; } = null;
     public bool IsActive { get; set; } = true;
     public bool IsJokerFlag { get; set; } = false;
     public List<KnownUserProfileViewModel> KnownUserProfiles { get; set; } = new();

} 
        