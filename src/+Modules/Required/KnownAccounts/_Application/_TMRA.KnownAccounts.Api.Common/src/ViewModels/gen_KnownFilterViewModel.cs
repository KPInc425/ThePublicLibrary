// ag=yes
namespace TPL.KnownAccounts.Api.Common.ViewModels; 
public partial class KnownFilterViewModel : ViewModelBase<Guid>
{ 

     public string Name { get; set; } = "";
     public bool IsActive { get; set; } = true;

} 
        