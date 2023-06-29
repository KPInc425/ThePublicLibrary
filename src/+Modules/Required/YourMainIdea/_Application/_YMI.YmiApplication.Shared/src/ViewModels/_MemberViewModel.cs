namespace YMI.YmiApplication.Shared.ViewModels;
public class MemberViewModel : BaseViewModelTracked<Guid>
{
    public FullNameVOViewModel Name { get; set; } = new();
    public PhysicalAddyVOViewModel Address { get; set; } = new();
    public DigitalAddyVOViewModel? Email { get; set; }
    public DigitalAddyVOViewModel? Phone { get; set; }
    public List<MemberInMembershipViewModel> MemberInMemberships { get; set; } = new();

}
