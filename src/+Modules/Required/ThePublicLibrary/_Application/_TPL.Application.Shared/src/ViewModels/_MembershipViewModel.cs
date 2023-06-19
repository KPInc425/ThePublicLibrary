﻿namespace TPL.Application.Shared.ViewModels;
public class MembershipViewModel : BaseViewModelTracked<Guid>
{
    public Guid MembershipCardNumber { get; set; }
    public string MembershipTitle { get; set; }
    public DateTime MemberSince { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }

    public List<MemberInMembershipViewModel> MemberInMemberships { get; set; } = new();

}
