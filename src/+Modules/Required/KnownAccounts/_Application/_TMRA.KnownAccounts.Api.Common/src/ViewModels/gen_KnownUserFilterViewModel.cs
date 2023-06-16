// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class KnownUserFilterViewModel : ViewModelBase<Guid>
{ 

     public string Name { get; set; } = "";
     public bool IsActive { get; set; } = true;

} 
        