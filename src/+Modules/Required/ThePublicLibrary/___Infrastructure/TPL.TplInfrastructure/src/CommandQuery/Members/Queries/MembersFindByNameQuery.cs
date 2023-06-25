namespace TPL.TplInfrastructure.CommandQuery;

public class MembersFindByNameQuery : IRequest<List<Member>>
{
    
    [Required]
    public string SearchFor { get; set; }

    public MembersFindByNameQuery(string searchFor)
    {
        SearchFor = searchFor;
    }
    
}
