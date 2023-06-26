namespace YMI.YmiApplication.Shared.ViewModels;
public class MemberViewModel : BaseViewModelTracked<Guid>
{
    public NameVOViewModel Name { get; set; }
    public PhysicalAddressVOViewModel Address { get; set; }
    public DigitalAddressVOViewModel? Email { get; set; }
    public DigitalAddressVOViewModel? Phone { get; set; }
    public List<MemberInMembershipViewModel> MemberInMemberships { get; set; } = new();

}
