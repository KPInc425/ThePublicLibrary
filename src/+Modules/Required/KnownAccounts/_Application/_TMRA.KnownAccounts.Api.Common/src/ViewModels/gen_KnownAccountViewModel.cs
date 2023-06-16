// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class KnownAccountViewModel : ViewModelBase<Guid>
{ 

     [MaxLength(101)]
     public string Name { get; set; } = "";
     [MaxLength(100)]
     public string? EmailAddress { get; set; } = null;
     [MaxLength(100)]
     public string? AliasName { get; set; } = null;
     public bool IsActive { get; set; } = true;
     public bool IsJokerFlag { get; set; } = false;
     public List<KnownAccountProfileViewModel> KnownAccountProfiles { get; set; } = new();

} 
        