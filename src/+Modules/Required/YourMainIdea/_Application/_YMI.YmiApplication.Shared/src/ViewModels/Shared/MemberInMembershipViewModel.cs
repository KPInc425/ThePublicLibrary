namespace YMI.YmiApplication.Shared.ViewModels;
public class MemberInMembershipViewModel : BaseViewModelTracked<Guid>
{
    public MemberViewModel Member { get; set; }
    public MembershipViewModel Membership { get; set; }

}
