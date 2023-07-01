// ag=yes
namespace KnownAccountsApi.Common.ViewModels; 
public partial class KnownUserFilterViewModel : ViewModelBase<Guid>
{ 

     public string Name { get; set; } = "";
     public bool IsActive { get; set; } = true;

} 
        