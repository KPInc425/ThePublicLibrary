namespace TPL.Core.Entities;
public class MemberBirthdayDomainEvent : BaseDomainEvent
{
    public Member Member { get; set; }
    public List<Membership> Memberships { get; set; }
    public MemberBirthdayDomainEvent(Member member, List<Membership> memberships)
    {
        Member = Guard.Against.Null(member, "Member is required");
        Memberships = Guard.Against.Null(memberships, "Memberships is required");
    }
}