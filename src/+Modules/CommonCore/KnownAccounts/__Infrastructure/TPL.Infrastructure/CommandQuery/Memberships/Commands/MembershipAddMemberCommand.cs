namespace TPL.Infrastructure.CommandQuery;
public class MembershipAddMemberCommand : IRequest<Membership>, IRoutable
{
    protected static string Route = "/membership/add";
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int DurationInMonths { get; set; }
    public decimal Discount { get; set; }

    public MembershipAddMemberCommand(string name)
    {
        Name = name;
    }
    public MembershipAddMemberCommand(string name, string description, decimal price, int durationInMonths, decimal discount)
    {
        Name = name;
        Description = description;
        Price = price;
        DurationInMonths = durationInMonths;
        Discount = discount;
    }

    public string BuildRouteFrom() {
        return MembershipAddMemberCommand.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
