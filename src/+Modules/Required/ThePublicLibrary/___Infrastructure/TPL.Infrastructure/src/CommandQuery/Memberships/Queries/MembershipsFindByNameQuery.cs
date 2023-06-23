namespace TPL.Infrastructure.CommandQuery;

public class MembershipsFindByNameQuery : IRequest<List<Membership>>
{
    [Required]
    public string SearchFor { get; set; }

    public MembershipsFindByNameQuery(string searchFor)
    {
        SearchFor = searchFor;
    }
}
